using SqlTranslator.Application.Services;
using SqlTranslator.Domain.Entities;
using Xunit;

namespace SqlTranslator.Tests.Services
{
    public class SqlTranslationServiceTests
    {
        [Fact]
        public void Translate_SimpleSelectWithTopStatement_CorrectTranslation()
        {
            var service = new SqlTranslationService();
            var query = new SqlQuery
            {
                QueryText = "SELECT TOP 10 * FROM Users",
                SourceDatabase = "SQLServer",
                TargetDatabase = "Oracle"
            };
            var expected = "SELECT * FROM Users WHERE ROWNUM <=10";

            var result = service.Translate(query);

            Assert.Equal(expected, result);
        }
    }
}
