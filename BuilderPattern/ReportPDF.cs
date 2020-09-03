using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ReportPDF : ReportBuilder
    {
        public override void SetReportFooter()
        {
            Report.SetReportFooter("PDF footer");
        }

        public override void SetReportHeader()
        {
            Report.SetReportHeader("PDF header");
        }

        public override void SetReportType()
        {
            Report.SetReportType("PDF");
        }
    }
}
