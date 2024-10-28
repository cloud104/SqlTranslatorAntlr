

namespace SqlTranslator.Domain.Entities
{
    public class SqlQuery
    {
        public string QueryText { get; set; }
        public string SourceDatabase { get; set; }
        public string TargetDatabase { get; set; }

    }
}
