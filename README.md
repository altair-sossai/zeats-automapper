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

### enum.Description()
Returns the description of the enum using the attribute System.ComponentModel.DescriptionAttribute
```c#
private enum SampleEnum
{
    Option01,

    [Description("Option 02")]
    Option02
}

SampleEnum.Option01.Description() /* return "Option01" */
SampleEnum.Option02.Description() /* return "Option 02" */
```
---
