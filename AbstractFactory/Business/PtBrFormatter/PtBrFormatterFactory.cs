namespace AbstractFactory.Business.PtBrFormatter
{
    public class PtBrFormatterFactory
    {
        public PtBrFormatter GetHeaderFormatter() => new PtBrFormatter();
        public PtBrFormatter GetBodyFormatter() => new PtBrFormatter();
    }
}