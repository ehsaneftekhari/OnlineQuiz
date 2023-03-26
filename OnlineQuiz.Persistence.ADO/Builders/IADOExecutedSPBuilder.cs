using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz.Persistence.ADO.Builders
{
    public interface IADOExecutedSPBuilder
    {
        object GetValueOfOutputParameters(string parameterName);

        Type GetValueOfOutputParameters<Type>(string parameterName);

        IDictionary<string, object> GetValueOfOutputParameters(params string[] parameterNames);
    }
}
