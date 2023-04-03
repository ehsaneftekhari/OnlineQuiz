namespace OnlineQuiz.Persistence.ADO.Builders
{
    public interface IADOExecutedSPBuilder
    {
        object GetValueOfOutputParameter(string parameterName);

        Type GetValueOfOutputParameter<Type>(string parameterName);

        IDictionary<string, object> GetValueOfOutputParameters(params string[] parameterNames);
    }
}
