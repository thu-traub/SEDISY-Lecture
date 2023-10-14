param (
    [Parameter(mandatory=$true)]$protocol,
    [Parameter(mandatory=$true)]$side
)

python "$protocol\python\$side\$side.py"