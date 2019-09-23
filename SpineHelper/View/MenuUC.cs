using System;
using System.Drawing;
using System.Windows.Forms;
using SpineHelper.Device;
using System.IO;
using System.Diagnostics;
using SpineHelper.View.Calibration;
using SpineHelper.View.Device;
using SpineHelper.View.Options;
using SpineHelper.View.Help;

namespace SpineHelper.View
{
    public partial class MenuUC : UserControl
    {
        public MenuUC()
        {
            InitializeComponent();

            buttonFile.MouseDown += FileClicked;
            buttonOptions.MouseDown += OptionsClicked;
            buttonDevice.MouseDown += DeviceClicked;
            buttonHelp.MouseDown += HelpClicked;
        }


        private void FileClicked(object sender, EventArgs e)
        {
            OpenContextMenu(sender as Control, contextMenuFile);
        }

        private void OptionsClicked(object sender, EventArgs e)
        {
            OpenContextMenu(sender as Control, contextMenuOptions);
        }

        private void DeviceClicked(object sender, EventArgs e)
        {
            OpenContextMenu(sender as Control, contextMenuDevice);
        }

        private void HelpClicked(object sender, EventArgs e)
        {
            OpenContextMenu(sender as Control, contextMenuHelp);
        }



        private void OpenContextMenu(Control control, ContextMenuStrip menu)
        {
            CloseRemainingMenus(menu);

            if (menu.Visible)
            {
                menu.Hide();
            }
            else
            {
                if (menu == contextMenuDevice)
                    UpdateConnectionState();

                control.ContextMenuStrip = menu;
                Point p = new Point(0, 25);
                control.ContextMenuStrip.Show(control, p);
            }
        }

        private void CloseRemainingMenus(ContextMenuStrip menu)
        {
            if (menu != contextMenuFile)
                contextMenuFile.Hide();

            if (menu != contextMenuOptions)
                contextMenuOptions.Hide();

            if (menu != contextMenuDevice)
                contextMenuDevice.Hide();

            if (menu != contextMenuHelp)
                contextMenuHelp.Hide();
        }


        #region FileMenu
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnLoadHistory();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnSaveHistory();
        }

        private void exportHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnExportHistory();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalEventManager.instance.OnExitApplication();
        }
        #endregion

        #region OptionsMenu
        private void historyViewStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager.instance.TryOpen<HistoryViewForm>();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager.instance.TryOpen<PreferencesForm>();
        }
        #endregion

        #region DeviceMenu
        private void deviceInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckDeviceConnected())
            {
                WindowManager.instance.TryOpen<DeviceInfoForm>();
            }
        }

        private void tareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConnectionManager.instance.DeviceConnectionState >= DeviceState.Connected)
                ConnectionManager.instance.Send(DeviceCodes.DEVICE_CODE_TARE);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConnectionManager.instance.DeviceConnectionState < DeviceState.Connected)
                ConnectionManager.instance.RequestConnection();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConnectionManager.instance.DeviceConnectionState >= DeviceState.Connected)
                ConnectionManager.instance.Disconnect();
        }

        private void calibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckDeviceConnected())
            {
                WindowManager.instance.TryOpen<CalibrationInfoForm>();
            }
        }

        private void installDriversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show(
                GlobalStrings.InstallDriversUSB,
                GlobalStrings.InstallDriversUSBHeader,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                byte[] exeBytes = Properties.Resources.CH340drivers;
                string exeToRun = Path.Combine(Path.GetTempPath(), "CH340drivers.exe");

                if (!File.Exists(exeToRun))
                {
                    using (FileStream exeFile = new FileStream(exeToRun, FileMode.CreateNew))
                        exeFile.Write(exeBytes, 0, exeBytes.Length);
                }
                Process.Start(exeToRun);
            }
        }
        #endregion



        #region HelpMenu


        private void checkUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Versioning.CheckForUpdates(true);
        }

        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager.instance.TryOpen<ChangelogForm>();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager.instance.TryOpen<AboutForm>();
        }

        #endregion



        private void UpdateConnectionState()
        {
            bool connected = ConnectionManager.instance.DeviceConnectionState >= DeviceState.Connected;
            disconnectToolStripMenuItem.Visible = connected;
            tareToolStripMenuItem.Visible = connected;
            connectToolStripMenuItem.Visible = !connected;

            switch (ConnectionManager.instance.DeviceConnectionState)
            {
                case DeviceState.NotConnected:
                    connectionToolStripMenuItem.Text = GlobalStrings.DeviceNotConnected;
                    connectionToolStripMenuItem.ForeColor = Color.Red;
                    connectionToolStripMenuItem.Image = Properties.Resources.dot_red;
                    break;
                case DeviceState.ConnectionAttempt:
                    connectionToolStripMenuItem.Text = GlobalStrings.DeviceConnecting;
                    connectionToolStripMenuItem.ForeColor = Color.Blue;
                    connectionToolStripMenuItem.Image = Properties.Resources.dot_blue;
                    connectToolStripMenuItem.Visible = false;
                    break;
                case DeviceState.Connected:
                case DeviceState.Ready:
                    connectionToolStripMenuItem.Text = GlobalStrings.DeviceConnected;
                    connectionToolStripMenuItem.ForeColor = Color.DarkGreen;
                    connectionToolStripMenuItem.Image = Properties.Resources.dot_green;
                    break;
                default:
                    break;
            }

            //if (connectToolStripMenuItem.Visible)
            //    connectToolStripMenuItem.Text = DeviceConnectWith//need to save current port name in connection manager
        }


        private bool CheckDeviceConnected()
        {
            if (ConnectionManager.instance.DeviceConnectionState < DeviceState.Connected)
            {
                MessageBox.Show(GlobalStrings.NotConnectedPopup,
                    GlobalStrings.NotConnectedPopupHeader,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void viewManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenUrl(GlobalStrings.ManualLink);
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(GlobalStrings.ErrorOpeningWebPage + ex.Message, GlobalStrings.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
