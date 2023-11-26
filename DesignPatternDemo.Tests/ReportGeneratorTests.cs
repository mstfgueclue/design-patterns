using design_patterns.TemplatePattern;

namespace DesignPatternDemo.Tests;

using Xunit;

public class ReportGeneratorTests {
    private class TestReportGenerator : ReportGenerator {
        public bool IsGatherDataCalled { get; private set; }
        public bool IsAnalyzeDataCalled { get; private set; }
        public bool IsFormatReportCalled { get; private set; }

        protected override void GatherData() => IsGatherDataCalled = true;
        protected override void AnalyzeData() => IsAnalyzeDataCalled = true;
        protected override void FormatReport() => IsFormatReportCalled = true;
    }

    [Fact]
    public void GenerateReport_ShouldInvokeAllSteps() {
        // Arrange
        var reportGenerator = new TestReportGenerator();

        // Act
        reportGenerator.GenerateReport();

        // Assert
        Assert.True(reportGenerator.IsGatherDataCalled);
        Assert.True(reportGenerator.IsAnalyzeDataCalled);
        Assert.True(reportGenerator.IsFormatReportCalled);
    }
}
