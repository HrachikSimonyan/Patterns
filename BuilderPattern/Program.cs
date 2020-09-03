using System;

namespace BuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Execute()
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            ReportPDF reportPDF = new ReportPDF();
            report = reportDirector.MakeReport(reportPDF);
            report.DisplayReport();
            Console.WriteLine(new string('*',20));
            ReportExcel reportExcel = new ReportExcel();
            report = reportDirector.MakeReport(reportExcel);
            report.DisplayReport();
        }
    }
}
