$root = Resolve-Path (Join-Path $PSScriptRoot "..")
$project = "$root\src\NGuard\NGuard.csproj"
dotnet pack $project --output "$root\artifacts" --configuration Release -p:ContinuousIntegrationBuild=true
