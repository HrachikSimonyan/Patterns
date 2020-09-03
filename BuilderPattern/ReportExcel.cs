using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ReportExcel : ReportBuilder
    {
        public override void SetReportFooter()
        {
            Report.SetReportFooter("Excel footer");
        }

        public override void SetReportHeader()
        {
            Report.SetReportHeader("Excel header");
        }

        public override void SetReportType()
        {
            Report.SetReportType("Excel");
        }
    }
}
