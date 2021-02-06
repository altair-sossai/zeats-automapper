<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-auto-mapper

Extensions to solve common problems when using enums

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-enum-extensions?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=18&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.EnumExtensions.svg)](https://www.nuget.org/packages/Zeats.Legacy.EnumExtensions)

## Installation

```PM>
Install-Package Zeats.Legacy.EnumExtensions
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
