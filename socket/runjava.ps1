param (
    [Parameter(mandatory=$true)]$protocol,
    [Parameter(mandatory=$true)]$side
)

javac "$protocol\java\$side\$side.java"
if ($?) {
    java -cp "$protocol\java\$side" $side
}