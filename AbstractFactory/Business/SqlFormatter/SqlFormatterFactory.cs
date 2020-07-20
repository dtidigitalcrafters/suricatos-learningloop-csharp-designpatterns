namespace AbstractFactory.Business.SqlFormatter
{
    public class SqlFormatterFactory : IFormatterFactory
    {
        public IFormatter GetHeaderFormatter() => new SqlHeaderFormatter();
        public IFormatter GetBodyFormatter() => new SqlBodyFormatter();
    }
}