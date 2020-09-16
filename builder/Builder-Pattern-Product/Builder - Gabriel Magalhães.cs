using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Implementação padrão Builder\n");
    var productBuilder = new ProductBuilder();
    var goiaba = productBuilder.Name("Goiaba")
        .Price(1.5)
        .Quantity(10)
        .Build();
    Console.WriteLine($"Name: {goiaba.Name} \nPrice: {goiaba.Price} \nQuantity: {goiaba.Quantity}");
  }

  public class ProductBuilder 
  {
    private readonly Product _product = new Product();

    public ProductBuilder Name(string name) { _product.Name = name; return this; }
    public ProductBuilder Price(double price) { _product.Price = price; return this; }
    public ProductBuilder Quantity(int quantity) { _product.Quantity = quantity; return this; }
    public Product Build() => _product;
  }

  public class Product
  {
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
  }
}