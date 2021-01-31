dotnet test --collect:"XPlat Code Coverage"

$testResultFolder = Get-ChildItem(".\TestResults") | Select-Object -First 1

reportgenerator "-reports:C:\Users\user\source\TestAlg\Algorithms.Tests\TestResults\${testResultFolder}\coverage.cobertura.xml" "-targetdir:coveragereport" -reporttypes:Html

Remove-Item ".\TestResults\" -Recurse