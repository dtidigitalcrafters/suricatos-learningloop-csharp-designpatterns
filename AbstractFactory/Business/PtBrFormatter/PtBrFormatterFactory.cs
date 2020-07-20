namespace AbstractFactory.Business.PtBrFormatter
{
    public class PtBrFormatterFactory : IFormatterFactory
    {
        public IFormatter GetHeaderFormatter() => new PtBrFormatter();
        public IFormatter GetBodyFormatter() => new PtBrFormatter();
    }
}