namespace StructuralComparison.Core.Models;

/// <summary>
/// Значение перечисления [<see langword="enum"/>]
/// </summary>
public readonly record struct EnumField(int Value, string Name)
{
    /// <summary>
    /// Значение перечисления
    /// </summary>
    public int Value { get; } = Value;

    /// <summary>
    /// Наименование значения перечисления
    /// </summary>
    public string Name { get; } = Name;
}
