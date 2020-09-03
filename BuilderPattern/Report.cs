using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Report
    {
        private string ReportType;
        private string ReportHeader;
        private string ReportFooter;
        public void SetReportType(string reportType)
        {
            ReportType = reportType;
        }
        public void SetReportHeader(string reportHeader)
        {
            ReportHeader = reportHeader;
        }

        public void SetReportFooter(string reportFooter)
        {
            ReportFooter = reportFooter;
        }

        public void DisplayReport()
        {
            Console.WriteLine($"Report type - {ReportType}");
            Console.WriteLine($"Report header - {ReportHeader}");
            Console.WriteLine($"Report footer - {ReportFooter}");
        }
    }
}
