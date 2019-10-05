using System;

namespace SpineHelper.History
{
    public class HistoryManager
    {
        public static readonly HistoryManager instance = new HistoryManager();

        public ArrowSet CurrentSet { get; private set; } = new ArrowSet();

        //public event Action<ArrowSet> PreviewPrint;
        //public event Action<ArrowSet> PrintHistory;

        static HistoryManager()
        {
        }

        private HistoryManager()
        {
        }


        public void LoadSet(ArrowSet set)
        {
            if (set != null)
                CurrentSet = set;
        }
    }

}
