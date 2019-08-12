using System;
using System.Deployment.Application;
using System.Windows.Forms;

namespace SpineHelper
{
    public static class Versioning
    {
        public static string Version
        {
            get
            {
                return string.Format("v{0}.{1}.{2}.{3}", MajorVersion, MinorVersion, Build, Revision);
            }
        }

        public static int MajorVersion
        {
            get
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                    return ApplicationDeployment.CurrentDeployment.CurrentVersion.Major;
                else
                    // Stored in Properties -> AssemblyInfo.cs
                    return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major;
            }
        }
        public static int MinorVersion
        {
            get
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                    return ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor;
                else
                    // Stored in Properties -> AssemblyInfo.cs
                    return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor;
            }
        }

        public static int Build
        {
            get
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                    return ApplicationDeployment.CurrentDeployment.CurrentVersion.Build;
                else
                    // Stored in Properties -> AssemblyInfo.cs
                    return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build;
            }
        }

        public static int Revision
        {
            get
            {
                if (ApplicationDeployment.IsNetworkDeployed)
                    return ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision;
                else
                    // Stored in Properties -> AssemblyInfo.cs
                    return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision;
            }
        }


        public static void CheckForUpdates(bool manual = false)
        {
            try
            {
                UpdateCheckInfo info = null;

                string debug = Settings.DebugMode && !manual ? GlobalStrings.DebugModeInfo : string.Empty;


                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                    try
                    {
                        info = ad.CheckForDetailedUpdate();

                    }
                    catch (DeploymentDownloadException dde)
                    {
                        if (manual || Settings.DebugMode)
                            MessageBox.Show(debug + GlobalStrings.UpdateConnectionError + dde.Message,
                                GlobalStrings.UpdateConnectionErrorHeader,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (InvalidDeploymentException ide)
                    {
                        if (manual || Settings.DebugMode)
                            MessageBox.Show(debug + GlobalStrings.UpdateInstallationError + ide.Message,
                            GlobalStrings.UpdateInstallationErrorHeader,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    catch (InvalidOperationException ioe)
                    {
                        if (manual || Settings.DebugMode)
                            MessageBox.Show(debug + GlobalStrings.UpdateApplicationError + ioe.Message,
                            GlobalStrings.UpdateApplicationErrorHeader,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (info.UpdateAvailable)
                    {
                        bool doUpdate = true;

                        if (!info.IsUpdateRequired)
                        {
                            DialogResult dr = MessageBox.Show(GlobalStrings.UpdateAvailable,
                                GlobalStrings.UpdateAvailableHeader,
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (!(DialogResult.OK == dr))
                            {
                                doUpdate = false;
                            }
                        }
                        else
                        {
                            // Display a message that app MUST reboot. Display the minimum required version.
                            MessageBox.Show(string.Format(
                                GlobalStrings.UpdateForced, info.MinimumRequiredVersion.ToString()),
                                GlobalStrings.UpdateAvailableHeader,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (doUpdate)
                        {
                            try
                            {
                                ad.Update();
                                MessageBox.Show(GlobalStrings.UpdateInstalled);
                                Application.Restart();
                            }
                            catch (DeploymentDownloadException dde)
                            {
                                MessageBox.Show(GlobalStrings.UpdateErrorNet + dde,
                                    GlobalStrings.UpdateConnectionErrorHeader,
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                return;
                            }
                        }
                    }
                    else
                    {
                        if (manual || Settings.DebugMode)
                            MessageBox.Show(debug + GlobalStrings.UpdateUpToDate,
                                GlobalStrings.UpdateUpToDateHeader,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (manual || Settings.DebugMode)
                        MessageBox.Show(debug + GlobalStrings.UpdateNotDeployed, GlobalStrings.Error,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                if (manual)
                    MessageBox.Show(GlobalStrings.UpdateFatalError, GlobalStrings.Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
