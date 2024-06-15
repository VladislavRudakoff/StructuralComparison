namespace StructuralComparison.Core.Models;

/// <summary>
/// Параметр метода
/// </summary>
public readonly record struct MethodParameter(Type Type, string Name)
{
    /// <summary>
    /// Тип параметра
    /// </summary>
    public Type Type { get; } = Type;

    /// <summary>
    /// Имя параметра
    /// </summary>
    public string Name { get; } = Name;
}
