using SpineHelper.History;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SpineHelper.Export
{
    public class DataSerializer
    {
        public const string SaveFormat = "SpineHelper Arrow Data|*.arrows";

        public static string SaveDirectory { get {return Common.MainDirectory; } }

        private static string ErrorMessageSave { get { return GlobalStrings.SerializerSaveError; } }
        private static string ErrorMessageLoad { get { return GlobalStrings.SerializerLoadError; } }

        public event Action<string> SaveFailed;
        public event Action<string> LoadFailed;
        public event Action SaveSuccessful;
        public event Action LoadSuccessful;


        public DataSerializer()
        {
        }

        public void SaveToFile(ArrowSet data, string fileName)
        {
            try
            {
                OnSave(SaveDataToFile(data, fileName));
            }
            catch (Exception ex)
            {
                OnSave(ErrorMessageSave + ex.Message);
            }
        }

        public void LoadFromFile(ref ArrowSet data, string fileName)
        {
            try
            {
                OnLoad(LoadDataFromFile(ref data, fileName));
            }
            catch (Exception ex)
            {
                OnLoad(ErrorMessageLoad + ex.Message);
            }
        }

        private void OnSave(string errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage))
                SaveSuccessful?.Invoke();
            else
                SaveFailed?.Invoke(errorMessage);
        }

        private void OnLoad(string errorMessage)
        {
            if (string.IsNullOrEmpty(errorMessage))
                LoadSuccessful?.Invoke();
            else
                LoadFailed?.Invoke(errorMessage);
        }


        private string SaveDataToFile(ArrowSet arrowSet, string filename)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);

                formatter.Serialize(stream, arrowSet);
                stream.Close();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private string LoadDataFromFile(ref ArrowSet set, string filename)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
                set = (ArrowSet)formatter.Deserialize(stream);

                stream.Close();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }


    }



}
