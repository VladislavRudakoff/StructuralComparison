namespace StructuralComparison.Core.Models;

/// <summary>
/// Представляет собой тип класса-контракта(контроллера или клиента)
/// </summary>
/// <param name="Name">Название класса-контракта</param>
/// <param name="ShortName">Сокращённое название класса-контракта</param>
/// <param name="Methods">Методы класса-контракта</param>
public readonly record struct ContractType(string Name, string ShortName, IReadOnlyCollection<MethodMetadata> Methods);
