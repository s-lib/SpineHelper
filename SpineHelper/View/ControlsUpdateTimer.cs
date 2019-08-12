using System;
using System.Timers;

namespace SpineHelper.View
{
    public sealed class ControlsUpdateTimer
    {
        public static readonly ControlsUpdateTimer instance = new ControlsUpdateTimer();

        public event Action TimerTick;
        private Timer aTimer;

        static ControlsUpdateTimer()
        {
        }

        private ControlsUpdateTimer()
        {
            aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 500;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            TimerTick?.Invoke();
        }

    }


}

