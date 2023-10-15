param (
    [Parameter(mandatory=$true)]$protocol,
    [Parameter(mandatory=$true)]$side
)

node "$protocol\js\$side\$side.js"