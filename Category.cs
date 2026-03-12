class Category
{
    private string name;
    private string description;

    public Category(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public Category()
    {
        this.name = "";
        this.description = "";
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

    public string getDescription()
    {
        return this.description;
    }
    public void setDescription(string description)
    {
        this.description = description;
    }

    // propriété
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string Description
    {
        get { return this.description; }
        set { this.description = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Nom de la catégorie: {this.name}");
        Console.WriteLine($"Description de la catégorie: {this.description}");
    }
}