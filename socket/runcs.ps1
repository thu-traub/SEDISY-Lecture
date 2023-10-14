param (
    [Parameter(mandatory=$true)]$protocol,
    [Parameter(mandatory=$true)]$side
)

dotnet run --project "$protocol\cs\$side"