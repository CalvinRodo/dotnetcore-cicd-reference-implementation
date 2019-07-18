# dotnetcore-cicd-reference-implementation

A reference implementation demonstrating CI/CD for .Net Core applications

## Static Analysis

The Roslyn Compiler has a large number of static analysis tools available for
ensuring code correctness.

There are several first party analyzers that can be found here:

There are also numerous 3rd party analyzers such as the DotNet Analyzers Project

[Link to GitHub Analyzers GitHub Organization](https://github.com/DotNetAnalyzers)

### FXCop.Analyzer

For the purposes of this reference implementation we will only be using the
FXCop Analyzer.

### DotNet-Format

Dotnet Format will automatically format your code using the settings in your
`.editorconfig` file. For our reference pipeline we will be using the dry-run
and check settings to fail our pipeline if we don't meet the proper
configuration.

#### .editorconfig File

The use of a `.editorconfig` file should be used to enforce the default .Net
Coding Conventions.

Using the default .Net Coding Conventions will ensure consistency with .Net
Code written by others and also make it easier

[Link to `.editorconfig` instructions on MSDN site](https://docs.microsoft.com/en-gb/visualstudio/ide/editorconfig-code-style-settings-reference?view=vs-2019)

#### Command to run
