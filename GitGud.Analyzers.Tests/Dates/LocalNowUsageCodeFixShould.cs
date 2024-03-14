using GitGud.Analyzers.Tests.Dates.Generators;
using Verifier =
    Microsoft.CodeAnalysis.CSharp.Testing.XUnit.CodeFixVerifier<GitGud.Analyzers.Dates.LocalNowUsageAnalyzer,
        GitGud.Analyzers.Dates.LocalNowUsageCodeFix>;

namespace GitGud.Analyzers.Tests.Dates;

public class LocalNowUsageCodeFixShould
{
    [Theory]
    [ClassData(typeof(LocalNowCodeFixCaseGenerator))]
    public async Task Replace_DateTime_Now_With_DateTime_Utc_Now(string badCode, int line, 
        int column, string fixedCode)
    {
        var expectedDiagnosticResult = Verifier.Diagnostic()
            .WithLocation(line, column);
        
        await Verifier.VerifyCodeFixAsync(badCode, expectedDiagnosticResult, fixedCode)
            .ConfigureAwait(false);
    }
}