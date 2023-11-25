namespace design_patterns.TemplatePattern;

public class CustomerActivityReportGenerator : ReportGenerator
{
    protected override void GatherData()
    {
         /* Implementation */
         Console.WriteLine("Gathering customer activity data: CustomerActivityReportGenerator");
    }

    protected override void AnalyzeData()
    {
         /* Implementation */
         Console.WriteLine("Analyzing customer activity data: CustomerActivityReportGenerator");
    }

    protected override void FormatReport()
    {
         /* Implementation */
         Console.WriteLine("Formatting customer activity report: CustomerActivityReportGenerator");
    }
}