using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }
}
