class Item
{
    private string name;
    private double price;
    private int quantity;

    public Item(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public Item()
    {
        this.name = "";
        this.price = 0.0;
        this.quantity = 0;
    }

    // Getters et Setters
    public string getName()
    {
        return this.name;
    }
    public void setName(string name)
    {
        this.name = name;
    }

    public double getPrice()
    {
        return this.price;
    }
    public void setPrice(double price)
    {
        this.price = price;
    }

    public int getQuantity()
    {
        return this.quantity;
    }
    public void setQuantity(int quantity)
    {
        this.quantity = quantity;
    }

    // propriété
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }
    public int Quantity
    {
        get { return this.quantity; }
        set { this.quantity = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Nom de l'objet: {this.name}");
        Console.WriteLine($"Prix de l'objet: {this.price}");
        Console.WriteLine($"Quantité de l'objet: {this.quantity}");
    }
}