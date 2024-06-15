namespace StructuralComparison.Core.Models;

/// <summary>
/// Метаданные метода
/// </summary>
public readonly record struct MethodMetadata(string MethodName, MethodParameter[] Parameters, Type ReturnType)
{
    /// <summary>
    /// Название метода
    /// </summary>
    public string Name { get; } = MethodName;

    /// <summary>
    /// Параметры метода
    /// </summary>
    public MethodParameter[] Parameters { get; } = Parameters;

    /// <summary>
    /// Возвращаемый тип метода
    /// </summary>
    public Type ReturnType { get; } = ReturnType;
}
