using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        private bool _isRuning;
        private bool _isStart;
        private Timer _automationTimer;


        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var interval = 1000;

            this._isStart = true;
            this._automationTimer = new Timer(AutorunTask, null, interval, interval);
            WriteLog("AutomationListenerService started", EventLogEntryType.Information);

        }

        private void AutorunTask(object state)
        {
           
            WriteLog("APTECH LOGS at " + DateTime.Now.ToString(), EventLogEntryType.Information);
        }
        protected override void OnStop()
        {
        }

        private void WriteLog(string message, EventLogEntryType eventLogEntryType)
        {
            try
            {
                var sourceName = "APTECH - Automation Service Solutions";
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                EventLog.WriteEntry(sourceName, message, eventLogEntryType);
            }
            catch
            {

            }
        }

    }
}
