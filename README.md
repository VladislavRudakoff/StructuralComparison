# Structural Comparison

## Overview
This tool is designed to help compare two types structurally to ensure consistency and compatibility.
It compares the properties of the two types based on names and data types, or examines the methods within the types
by analyzing parameter names, parameter types, and output types.

The primary aim of this project is to facilitate automatic checks to verify that the contracts specified in,
for instance, the ***.Contracts** project are congruent with the **controllers** in the current project.
By doing so, it ensures that there are no discrepancies between the contracts and the implementation in the controllers,
thereby guaranteeing that the contracts remain relevant and up-to-date.

## How it works
The Type Comparison Tool utilizes a sophisticated algorithm to analyze the structure of two types and systematically
compare their properties and methods. It provides detailed reports highlighting any differences detected in the properties,
methods, and parameters of the types being compared.

## Getting Started

To start using, install the Nuget package **StructuralComparison** (**_it does not exist yet_**)

There are several methods that allow you to compare different types of data:

- **Enums**
```cs
public static bool Compare(Type firstType, Type secondType)
{
    AssertResult result = StructuralComparisonService.CompareEnums(firstType, secondType);

    return result.IsSuccessful;
}
```

> If both types are not enums, then the result of the comparison will immediately contain a description of the error, and the **isSuccessful** property will be set to **_false_**

- **CustomTypes**
```cs

```

- **Methods**
```cs

```

- **Contracts**
```cs

```

## Contributing
Contributions to this project are welcome.
If you have suggestions, feature requests, or would like to report issues, please feel free to open an issue or submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.
