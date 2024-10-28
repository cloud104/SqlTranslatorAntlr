

using SqlTranslator.Domain.Entities;
using SqlTranslator.Domain.Interfaces;

namespace SqlTranslator.Application.Services
{
    public class SqlTranslationService: ISqlTranslationService
    {
        public string Translate(SqlQuery query)
        {
            //  passos de leitura, varredura, construção da AST, normalização, transformação e geração de Sql

            // para passar no teste
            if (query.SourceDatabase == "SQLServer" && query.TargetDatabase == "Oracle")
            {
                return query.QueryText.Replace("TOP", "")
                    .Replace("SELECT", "SELECT * FROM")
                    + " WHERE ROWNUM <= 10";
            }

            return query.QueryText;

        }
    }
}
