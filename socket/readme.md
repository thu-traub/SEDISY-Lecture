# Socket Examples

Here, you can find some basic socket examples. 
I've excluded any error handling to keep things as simple as possible.

To run the samples (replace the arguments in square brackets):

## Windows

    .\run[lang].ps1 [protocol] [side]

where lang:

- `cs` for C#
- `py` for Python
- `java` for Java
- `js` for JavaScript
- `c` for C language

and protocol:

- tcp
- udp

and side:

- server
- client

For examples, open two windows and type

    .\runcs.ps1 tcp server

and

    .\runpy tcp client

This launches a TCP server in C# and a Python client.

# Linux

Replace `.\run[lang].ps1` with `./run[lang]`
