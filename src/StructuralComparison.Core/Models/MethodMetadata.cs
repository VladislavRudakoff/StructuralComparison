namespace StructuralComparison.Core.Models;

/// <summary>
/// Метаданные метода
/// </summary>
/// <param name="Name">Название метода</param>
/// <param name="Parameters">Параметры метода</param>
/// <param name="ReturnType">Возвращаемый тип метода</param>
public readonly record struct MethodMetadata(string Name, IReadOnlyCollection<MethodParameter> Parameters, Type ReturnType);
