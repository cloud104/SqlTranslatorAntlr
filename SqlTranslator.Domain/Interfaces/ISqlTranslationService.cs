

using SqlTranslator.Domain.Entities;

namespace SqlTranslator.Domain.Interfaces
{
    public interface ISqlTranslationService
    {
        string Translate(SqlQuery query);
    }
}
