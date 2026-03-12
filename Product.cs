class Product
{
    private string name;
    private double price;
    private int id;
    private static int nextId = 1;

    private Supplier supplier;

    public Product(string name, double price, Supplier supplier)
    {
        this.id = nextId;
        nextId++;
        this.name = name;
        this.price = price;
        this.supplier = supplier;
    }

    public Product()
    {
        this.id = nextId;
        nextId++;
        this.name = "";
        this.price = 0.0;
        this.supplier = new Supplier();
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

    public Supplier getSupplier()
    {
        return this.supplier;
    }
    public void setSupplier(Supplier supplier)
    {
        this.supplier = supplier;
    }

    public int getId()
    {
        return this.id;
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
    public Supplier Supplier
    {
        get { return this.supplier; }
        set { this.supplier = value; }
    }
    public int Id
    {
        get { return this.id; }
    }


    public void Display()
    {
        Console.WriteLine($"nom du produit: {this.name}");
        Console.WriteLine($"Prix du produit: {this.price}");
        Console.WriteLine($"Fournisseur du produit: {this.supplier.Name}");
    }
}