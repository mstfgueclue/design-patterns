namespace design_patterns.TemplatePattern;

public class SalesReportGenerator : ReportGenerator
{
    protected override void GatherData()
    {
         /* Implementation */
         Console.WriteLine("Gathering sales data: SalesReportGenerator");
    }

    protected override void AnalyzeData()
    {
         /* Implementation */
         Console.WriteLine("Analyzing sales data: SalesReportGenerator");
    }

    protected override void FormatReport()
    {
         /* Implementation */
         Console.WriteLine("Formatting sales report: SalesReportGenerator");
    }
}