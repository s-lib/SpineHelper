using System;
using System.IO;

namespace SpineHelper
{
    public static class Common
    {
        public const string ApplicationName = "SpineHelper";
        public const string Space = " ";
        public const string Colon = ":";
        public const string InvalidDirectory = "c:";
        public const string NoData = "----";


        private const string directoryName = ApplicationName;

        public static string MainFormName { get { return ApplicationName + Space + Versioning.Version; } }


        public static DateTime BuildDate
        {
            get
            {
                DateTime date = new DateTime(2000, 1, 1);
                return date.AddDays(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build);
            }
        }


        public static string MainDirectory
        {
            get
            {
                string path = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents");
                path = Path.Combine(path, directoryName);

                try
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    return path;
                }
                catch (Exception)
                {
                    return InvalidDirectory;
                }
            }
        }



    }
}
