namespace StructuralComparison.Core.Models;

/// <summary>
/// Представляет собой тип класса-контракта(контроллера или клиента)
/// </summary>
public readonly record struct ContractType(string Name, string ShortName, MethodMetadata[] Methods)
{
    /// <summary>
    /// Название класса-контракта
    /// </summary>
    public string Name { get; } = Name;

    /// <summary>
    /// Сокращённое название класса-контракта
    /// </summary>
    public string ShortName { get; } = ShortName;

    /// <summary>
    /// Методы класса-контракта
    /// </summary>
    public MethodMetadata[] Methods { get; } = Methods;
}
