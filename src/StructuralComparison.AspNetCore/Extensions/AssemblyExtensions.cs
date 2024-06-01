namespace StructuralComparison.AspNetCore.Extensions;

/// <summary>
/// Методы расширения для <see cref="Assembly"/>
/// </summary>
public static class AssemblyExtensions
{
    /// <summary>
    /// Возвращает все контроллеры
    /// </summary>
    /// <param name="assembly">Текущая сборка</param>
    /// <param name="filter">Фильтр по которому осуществляется выборка из контроллеров</param>
    /// <returns>Отфильтрованные классы контроллеров из текущей сборки</returns>
    public static IEnumerable<Type> GetAllControllersByFilter(
        this Assembly assembly,
        Func<Type, bool> filter) =>
        assembly.GetAllChildTypes<ControllerBase>().Where(filter).ToArray();

    /// <summary>
    /// Возвращает все контроллеры
    /// </summary>
    /// <param name="assembly">Текущая сборка</param>
    /// <returns>Все классы контроллеров из текущей сборки</returns>
    public static IEnumerable<Type> GetAllControllers(this Assembly assembly) => assembly.GetAllChildTypes<ControllerBase>();
}
