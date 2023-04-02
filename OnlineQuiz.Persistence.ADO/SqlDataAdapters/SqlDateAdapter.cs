namespace OnlineQuiz.Persistence.ADO.SqlDataAdapters
{
    public class SqlDateAdapter
    {
        public DateTime? ToDataTime(object SqlObject)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return null;

            DateTime datetime = Convert.ToDateTime(SqlObject)!;

            return datetime;
        }

        public TimeSpan? ToTimeSpan(object SqlObject)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return null;

            return (TimeSpan)SqlObject;
        }

        public int ToInt32(object SqlObject, int defaultValue)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return defaultValue;

            return Convert.ToInt32(SqlObject);
        }

        public int? ToInt32(object SqlObject)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return null;

            return Convert.ToInt32(SqlObject);
        }

        public double ToDouble(object SqlObject, double defaultValue)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return defaultValue;

            return Convert.ToDouble(SqlObject);
        }

        public double? ToDouble(object SqlObject)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return null;

            return Convert.ToDouble(SqlObject);
        }

        public string ToString(object SqlObject)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return null;

            return Convert.ToString(SqlObject);
        }

        public bool ToBoolean(object SqlObject, bool defaultValue)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return defaultValue;

            return Convert.ToBoolean(SqlObject);
        }

        public bool? ToBoolean(object SqlObject)
        {
            var type = SqlObject.GetType();

            if (type.Name == "DBNull")
                return null;

            return Convert.ToBoolean(SqlObject);
        }
    }
}
