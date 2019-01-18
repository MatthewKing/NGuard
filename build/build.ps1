$root = Resolve-Path (Join-Path $PSScriptRoot "..")
$project = "$root\src\NGuard"
dotnet pack $project --output "$root\artifacts" --configuration "Release"
