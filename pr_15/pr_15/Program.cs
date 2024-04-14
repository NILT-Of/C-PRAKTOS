using System;

class Lecarstvo
{ 
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Lecarstvo(string name, string manufacturer, int quantity, decimal price, DateTime expiryDate)
    {
        Name = name;
        Manufacturer = manufacturer;
        Quantity = quantity;
        Price = price;
        ExpiryDate = expiryDate;
    }
}

class pr_15
{
    static void Main(string[] args)
    {
        Lecarstvo medication1 = new Lecarstvo("Аспирин", "Bayer", 1488, 2.5m, new DateTime(2024, 12, 31));
        Lecarstvo medication2 = new Lecarstvo("Но-шпа", "Sanofi", 228, 3.0m, new DateTime(2025, 6, 30));

        Console.WriteLine("Информация о лекарственных препаратах:");
        Console.WriteLine($"Препарат: {medication1.Name}, Производитель: {medication1.Manufacturer}, Количество: {medication1.Quantity}, Цена: {medication1.Price}, Срок годности: {medication1.ExpiryDate.ToShortDateString()}");
        Console.WriteLine($"Препарат: {medication2.Name}, Производитель: {medication2.Manufacturer}, Количество: {medication2.Quantity}, Цена: {medication2.Price}, Срок годности: {medication2.ExpiryDate.ToShortDateString()}");
    }
}
