namespace design_patterns.TemplatePattern;

public abstract class ReportGenerator
{
    public void GenerateReport() {
        GatherData();
        AnalyzeData();
        FormatReport();
    }

    protected abstract void GatherData();
    protected abstract void AnalyzeData();
    protected abstract void FormatReport();
}