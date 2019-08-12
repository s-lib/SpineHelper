using System;
using SpineHelper.History;

namespace SpineHelper
{
    public class GlobalEventManager
    {
        public static readonly GlobalEventManager instance = new GlobalEventManager();


        public event Action SpineUnitsSwitched;
        public event Action WeightUnitsSwitched;
        public event Action AutoAddToHistorySwitched;

        public event Action<ArrowData> AddToHistory;
        public event Action ClearHistory;
        public event Action RemoveFromHistory;
        public event Action SaveHistory;
        public event Action LoadHistory;
        public event Action ExportHistory;

        public event Action ExitApplication;

        static GlobalEventManager()
        {
        }

        private GlobalEventManager()
        {
        }

        public void OnSpineUnitsSwitched()
        {
            Settings.SpineAMO = !Settings.SpineAMO;
            Settings.Save();
            SpineUnitsSwitched?.Invoke();
        }

        public void OnWeightUnitsSwitched()
        {
            Settings.WeightGrams = !Settings.WeightGrams;
            Settings.Save();
            WeightUnitsSwitched?.Invoke();
        }

        public void OnAutoAddToHistorySwitched()
        {
            Settings.AutoAddToHistory = !Settings.AutoAddToHistory;
            Settings.Save();
            AutoAddToHistorySwitched?.Invoke();
        }



        public void OnAddToHistory(ArrowData arrow)
        {
            AddToHistory?.Invoke(arrow);
        }

        public void OnRemoveFromHistory()
        {
            RemoveFromHistory?.Invoke();
        }

        public void OnClearHistory()
        {
            ClearHistory?.Invoke();
        }

        public void OnSaveHistory()
        {
            SaveHistory?.Invoke();
        }
        public void OnLoadHistory()
        {
            LoadHistory?.Invoke();
        }

        public void OnExportHistory()
        {
            ExportHistory?.Invoke();
        }

        public void OnExitApplication()
        {
            ExitApplication?.Invoke();
        }

    }

}
