<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-automapper

Extensions to facilitate AutoMapper use

[![Build Status](https://dev.azure.com/zeats/Zeats/_apis/build/status/build-zeats-automapper?branchName=master)](https://dev.azure.com/zeats/Zeats/_build/latest?definitionId=44&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.AutoMapper.svg)](https://www.nuget.org/packages/Zeats.AutoMapper)

## Installation

```PM>
dotnet add package Zeats.AutoMapper
```

## Extensions

### ForMember(destination, origin)
This package aims to facilitate the writing of the mapping code, writing less.

See the following example:
```c#
private class Source
{
    public string Name { get; set; }
}

public class Target
{
    public string CompanyName { get; set; }
    public string Document { get; set; }
}

private class CustomProfile : Profile
{
    public CustomProfile()
    {
        CreateMap<Source, Target>()
            .ForMember(t => t.CompanyName, s => s.Name)
            .ForMember(t => t.Document, "fixed-value");
    }
}
```
---
