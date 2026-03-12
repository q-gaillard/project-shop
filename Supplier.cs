class Supplier
{
    private string name;
    private string city;
    private int phone;
    private int id;
    private static int nextId = 1;

    public Supplier(string name, string city, int phone)
    {
        this.id = nextId;
        nextId++;
        this.name = name;
        this.city = city;
        this.phone = phone;
    }

    public Supplier()
    {
        this.id = nextId;
        nextId++;
        this.name = "";
        this.city = "";
        this.phone = 0;
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

    public string getCity()
    {
        return this.city;
    }
    public void setCity(string city)
    {
        this.city = city;
    }

    public int getPhone()
    {
        return this.phone;
    }
    public void setPhone(int phone)
    {
        this.phone = phone;
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
    public string City
    {
        get { return this.city; }
        set { this.city = value; }
    }
    public int Phone
    {
        get { return this.phone; }
        set { this.phone = value; }
    }
    public int Id
    {
        get { return this.id; }
    }

    public void Display()
    {
        Console.WriteLine($"Nom du fournisseur: {this.name}");
        Console.WriteLine($"Ville du fournisseur: {this.city}");
        if (this.phone != 0)
        {
            Console.WriteLine($"Téléphone du fournisseur: {this.phone}");
        }
        else
        {
            Console.WriteLine("Téléphone du fournisseur: aucun numéro de téléphone fourni");
        }
    }
}