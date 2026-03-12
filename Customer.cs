class Customer
{
    private string firstName;
    private string lastName;
    private int id;
    private static int nextId = 1;

    private string email;

    public Customer(string firstName, string lastName, string email)
    {
        this.id = nextId;
        nextId++;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
    }

    public Customer()
    {
        this.id = nextId;
        nextId++;
        this.firstName = "";
        this.lastName = "";
        this.email = "";
    }

    // Getters et Setters
    public string getFirstName()
    {
        return this.firstName;
    }
    public void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public string getLastName()
    {
        return this.lastName;
    }
    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public string getEmail()
    {
        return this.email;
    }
    public void setEmail(string email)
    {
        this.email = email;
    }

    public int getId()
    {
        return this.id;
    }

    // propriété
    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }
    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }
    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }
    public int Id
    {
        get { return this.id; }
    }

    public void Display()
    {
        Console.WriteLine($"nom du client: {this.firstName} {this.lastName}");
        Console.WriteLine($"Email du client: {this.email}");
    }
}