namespace AbstractFactory.Business
{
    public interface IFormatterFactory
    {
        IFormatter GetHeaderFormatter();
        IFormatter GetBodyFormatter();
    }
}