using System;
using System.Timers;

namespace BackupDatabase
{
    class MyService
    {
        Timer serviceTimer = null;
        public void Start()
        {
            serviceTimer = new Timer(1);
            serviceTimer.Elapsed += ServiceTimer_Elapsed;
            serviceTimer.Enabled = true;
            while (serviceTimer != null)
            {
                System.Threading.Thread.Sleep(10000);
            }
        }

        private void ServiceTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                serviceTimer.Enabled = false;
                BackUpCall();
                serviceTimer.Interval = TimerInterval;
                serviceTimer.Enabled = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

        public void Stop()
        {
            try
            {
                serviceTimer = null;
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

        private void BackUpCall()
        {
            try
            {
                BackupDatabase.Backup();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
        }

        private double TimerInterval
        {
            get
            {
                DateTime currentTime = DateTime.Now;
                DateTime timerRunningTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 19, 30, 0);
                timerRunningTime = timerRunningTime.AddDays(1);
                return (timerRunningTime - DateTime.Now).TotalMilliseconds;
            }
        }
    }
}
