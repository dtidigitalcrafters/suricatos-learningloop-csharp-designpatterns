using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderBuilder = new QueryBuilder("ORDER");
            Console.WriteLine(orderBuilder.Build());

            var paymentBuilder = new QueryBuilder("PAYMENT");
            string[] columns = { "PRICE", "DATE" };
            paymentBuilder.CreateSelect(columns);
            paymentBuilder.CreateWhere("PRICE > 89000");
            Console.WriteLine(paymentBuilder.Build());

            var carBuilder = new QueryBuilder("CAR");
            carBuilder.CreateWhere("BRAND_ID = 3");
            carBuilder.CreateOrderBy("RELEASE_YEAR", true);
            carBuilder.CreateOrderBy("MODEL_NAME");
            Console.WriteLine(carBuilder.Build());
        }
    }
}
