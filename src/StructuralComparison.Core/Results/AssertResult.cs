namespace StructuralComparison.Core.Results;

/// <summary>
/// Представляет собой агрегированный результат теста
/// </summary>
public readonly record struct AssertResult()
{
    public bool IsSuccessful => Errors.Count == 0;

    public AssertResult AddError(string errorMessage)
    {
        Errors.Add(errorMessage);

        return this;
    }

    public Collection<string> Errors { get; } = [];

    public AssertResult Combine(AssertResult assertResult)
    {
        if (assertResult.Errors.Count > 0)
        {
            foreach (string error in assertResult.Errors)
            {
                Errors.Add(error);
            }
        }

        return this;
    }
}
