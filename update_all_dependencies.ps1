# Script to update NetDaemon and all referenced packages to latest versions
# run from project root

Write-Host "Updating NuGet packages..."

# update NetDaemon packages only as an example
# you could also use dotnet-outdated tool or similar

Get-ChildItem -Recurse -Filter "*.csproj" | ForEach-Object {
    dotnet list "$_" package --outdated | Out-Host
}

Write-Host "Please review the output and apply updates manually, or use 'dotnet add package <Name> --version <Version>' to bump."