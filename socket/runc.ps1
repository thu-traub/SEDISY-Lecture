param (
    [Parameter(mandatory=$true)]$protocol,
    [Parameter(mandatory=$true)]$side
)

$vcv="C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvars32.bat"
if (!(Test-Path $vcv)) {
    echo "File '$vcv' not found, is Visual Studio 2022 installed?"
    exit 1
}

.\msc.bat "$protocol\c\$side\${side}_win.c" "/Fe`"$protocol\c\$side\$side.exe`"" "/Fo`"$protocol\c\$side\$side.obj`""
if (Test-Path "$protocol\c\$side\$side.obj") { del "$protocol\c\$side\$side.obj" }
Write-Host ""
& "$protocol\c\$side\$side.exe"