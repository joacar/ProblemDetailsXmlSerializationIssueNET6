# ProblemDetails Xml Serialization Issue NET6

XML serialization works in netcoreapp3.1 but fails in net6.0 where it serialize using JSON 
and return application/problem+json instead of application/xml. Content type is application/xml.

## Versions

```
dotnet --list-sdks
3.1.419 [C:\Program Files\dotnet\sdk]
```

```
> dotnet --version
6.0.202
```

## Test

Succeeds: `dotnet test ./test/TestProject1/TestProject1.csproj --framework netcoreapp3.1`

Fails: `dotnet test ./test/TestProject1/TestProject1.csproj --framework net6.0`
