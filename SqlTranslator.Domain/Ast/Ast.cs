namespace SqlTranslator.Domain.Ast
{
    public abstract class SqlNode { }

    public class SelectStatementNode : SqlNode
    {
        public List<string> Columns { get; set; }
        public string Table { get; set; }
        public string WhereClause { get; set; }
    }

    public class InsertStatementNode : SqlNode
    {
        public string Table { get; set; }
        public List<string> Columns { get; set; }
        public List<string> Values { get; set; }
    }

    // Outras classes para UPDATE, DELETE, etc.
}
