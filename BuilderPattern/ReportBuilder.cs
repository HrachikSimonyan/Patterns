using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class ReportBuilder
    {
        protected Report Report;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            this.Report = new Report();
        }
        public Report GetReport()
        {
            return this.Report;
        }
    }
}
