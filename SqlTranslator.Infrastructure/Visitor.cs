using SqlTranslator.Domain.Ast;

namespace SqlTranslator.Infrastructure.Visitors
{
    public class SqlToOracleVisitor : SqlBaseVisitor<SqlNode>
    {
        public override SqlNode VisitSelectStatement(SqlParser.SelectStatementContext context)
        {
            var node = new SelectStatementNode
            {
                Columns = context.columns().GetText(),
                Table = context.table().GetText(),
                WhereClause = context.where().GetText()
            };
            return node;
        }
 
    }
}
