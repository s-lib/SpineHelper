using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace SpineHelper
{
    public static class Settings
    {
        public enum Language { English, Polski }


        public static void Save()
        {
            Properties.Settings.Default.Save();
        }

        public static Language UILanguage
        {
            get { return (Language)Properties.Settings.Default.Language; }
        }

        public static int UILanguageIndex
        {
            get { return Properties.Settings.Default.Language; }
        }

        public static bool DebugMode
        {
            get { return Properties.Settings.Default.DebugMode; }
            set { Properties.Settings.Default.DebugMode = value; }
        }

        public static bool AutoUpdates
        {
            get { return Properties.Settings.Default.AutoUpdates; }
            set { Properties.Settings.Default.AutoUpdates = value; }
        }

        public static bool AutoAddToHistory
        {
            get { return Properties.Settings.Default.AutoAddToHistory; }
            set { Properties.Settings.Default.AutoAddToHistory = value; }
        }

        public static bool SpineAMO
        {
            get { return Properties.Settings.Default.SpineAMO; }
            set { Properties.Settings.Default.SpineAMO = value; }
        }

        public static bool WeightGrams
        {
            get { return Properties.Settings.Default.WeightGrams; }
            set { Properties.Settings.Default.WeightGrams = value; }
        }


        public static bool HistoryClearConfirmation
        {
            get { return Properties.Settings.Default.HistoryClearConfirmation; }
            set { Properties.Settings.Default.HistoryClearConfirmation = value; }
        }

        public static bool HistoryRemoveConfirmation
        {
            get { return Properties.Settings.Default.HistoryRemoveConfirmation; }
            set { Properties.Settings.Default.HistoryRemoveConfirmation = value; }
        }

        public static bool SaveLoadConfirmation
        {
            get { return Properties.Settings.Default.SaveLoadConfirmation; }
            set { Properties.Settings.Default.SaveLoadConfirmation = value; }
        }

        public static History.Data.Column HistoryHiddenColumns
        {
            get { return (History.Data.Column)Properties.Settings.Default.HistoryHiddenColumns; }
            set { Properties.Settings.Default.HistoryHiddenColumns = (int)value; }
        }

        public static bool SimplifiedConnectionInfo
        {
            get { return Properties.Settings.Default.SimplifiedConnectionInfo; }
            set { Properties.Settings.Default.SimplifiedConnectionInfo = value; }
        }




        public static void InitLanuage()
        {
            int index = Properties.Settings.Default.Language;
            var culture = new CultureInfo(GetLanguageCode(index));
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        public static void SetLanguage(int index)
        {
            if (Properties.Settings.Default.Language != index)
            {
                Properties.Settings.Default.Language = index;
                Save();
                InitLanuage();
            }
        }

        private static string GetLanguageCode(int index)
        {
            switch ((Language)index)
            {
                case Language.Polski: return "pl-PL";
                default: return "en";
            }
        }

        public static void LoadMainFormState(Form form)
        {
            if (Properties.Settings.Default.WindowLocation != null)
            {
                form.Location = Properties.Settings.Default.WindowLocation;
            }

            if (Properties.Settings.Default.WindowSize != null)
            {
                form.Size = Properties.Settings.Default.WindowSize;
            }

            if (Properties.Settings.Default.WindowState != FormWindowState.Minimized)
            {
                form.WindowState = Properties.Settings.Default.WindowState;
            }

        }

        public static void SaveFormState(Form form)
        {
            // Copy window location to app settings
            Properties.Settings.Default.WindowLocation = form.Location;

            // Copy window size to app settings
            if (form.WindowState == FormWindowState.Normal)
            {
                Properties.Settings.Default.WindowSize = form.Size;
            }
            else
            {
                Properties.Settings.Default.WindowSize = form.RestoreBounds.Size;
            }

            // Copy window state
            if (form.WindowState == FormWindowState.Maximized)
            {
                Properties.Settings.Default.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Properties.Settings.Default.WindowState = FormWindowState.Normal;
            }

            Save();
        }
    }

}
