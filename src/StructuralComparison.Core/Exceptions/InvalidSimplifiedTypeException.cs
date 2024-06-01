namespace StructuralComparison.Core.Exceptions;

/// <summary>
/// Исключение для типа не относящегося ни к одной группе
/// </summary>
public class InvalidSimplifiedTypeException(Type type) : Exception($"{type.FullName} относится к неизвестному типу данных");
