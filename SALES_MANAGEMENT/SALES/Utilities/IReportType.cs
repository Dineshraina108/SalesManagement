using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace SALES
{
    public interface IReportType
    {
        string FileName { get; }
        string FileExtension { get; }
        ReportFormat Format { get; }
    }

    public class ExcelReport : IReportType
    {
        public string FileName { get; }
        public string FileExtension { get; }
        public ReportFormat Format { get; }

        public ExcelReport(string FileName_ToOpen)
        {
            FileName = FileName_ToOpen;
            FileExtension = ".xls";
            Format = ReportFormat.EXCEL;
        }
    }

    public class PDFReport : IReportType
    {
        public string FileName { get; }
        public string FileExtension { get; }
        public ReportFormat Format { get; }

        public PDFReport(string FileName_ToOpen)
        {
            FileName = FileName_ToOpen;
            FileExtension = ".pdf";
            Format = ReportFormat.PDF;
        }
    }
}
