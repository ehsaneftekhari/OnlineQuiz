using OnlineQuiz.Library;
using System.Data;
using Section = OnlineQuiz.Business.Models.Models.Sections.Section;

namespace OnlineQuiz.Persistence.ADO.SqlDataAdapters
{
    internal class SectionDataTableAdapter : DataTableAdapter<Section>
    {

        public override Section ConvertDataRow(DataRow dataRow)
        {
            ThrowHelper.ThrowNullArgumentException(dataRow);

            SqlDateAdapter adapter = new SqlDateAdapter();

            int testId              = adapter.ToInt32(dataRow["TestId"], 0);
            int sectionId           = adapter.ToInt32(dataRow["SectionId"], 0);
            string sectionTitle     = adapter.ToString(dataRow["SectionTitle"]);
            DateTime? start         = adapter.ToDataTime(dataRow["Start"]);
            DateTime? end           = adapter.ToDataTime(dataRow["End"]);
            TimeSpan? duration      = adapter.ToTimeSpan(dataRow["Duration"]);
            int? order              = adapter.ToInt32(dataRow["Order"]);
            int? attemptLimit       = adapter.ToInt32(dataRow["AttemptLimit"]);
            bool randomizeQuestions = adapter.ToBoolean(dataRow["RandomizeQuestions"], false);
            bool displayResult      = adapter.ToBoolean(dataRow["DisplayResult"], false);
            bool allowEdit          = adapter.ToBoolean(dataRow["AllowEdit"], false);

            return new(sectionId, testId, sectionTitle, start, end, duration, order, attemptLimit, randomizeQuestions, displayResult, allowEdit);
        }
    }
}
