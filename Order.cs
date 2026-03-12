class Order
{
    private int orderNumber;
    private double totalAmount;
    private bool isPaid;
    private int id;
    private static int nextId = 1;

    private Customer customer;
    private List<Product> products;

    public Order(int orderNumber, double totalAmount, bool isPaid, Customer customer, List<Product> products)
    {
        this.id = nextId;
        nextId++;
        this.orderNumber = orderNumber;
        this.totalAmount = totalAmount;
        this.isPaid = isPaid;
        this.customer = customer;
        this.products = products;
    }

    public Order()
    {
        this.id = nextId;
        nextId++;
        this.orderNumber = 0;
        this.totalAmount = 0.0;
        this.isPaid = false;
        this.customer = new Customer();
        this.products = new List<Product>();
    }

    // Getters et Setters
    public int getOrderNumber()
    {
        // renvoie le numéro de commande ( get )
        return this.orderNumber;
    }
    public void setOrderNumber(int orderNumber)
    {
        // permet de modifier le numéro de commande ( set )
        this.orderNumber = orderNumber;
    }

    public double getTotalAmount()
    {
        // renvoie le montant total ( get )
        return this.totalAmount;
    }
    public void setTotalAmount(double totalAmount)
    {
        // permet de modifier le montant total ( set )
        this.totalAmount = totalAmount;
    }

    public bool getIsPaid()
    {
        // renvoie le statut de paiement ( get )
        return this.isPaid;
    }
    public void setIsPaid(bool isPaid)
    {
        // permet de modifier le statut de paiement ( set )
        this.isPaid = isPaid;
    }

    public Customer getCustomer()
    {
        // renvoie le client associé à la commande ( get )
        return this.customer;
    }
    public void setCustomer(Customer customer)
    {
        // permet de modifier le client associé à la commande ( set )
        this.customer = customer;
    }

    public List<Product> getProducts()
    {
        // renvoie la liste des produits de la commande ( get )
        return this.products;
    }
    public void setProducts(List<Product> products)
    {
        // permet de modifier la liste des produits de la commande ( set )
        this.products = products;
    }

    public int getId()
    {
        return this.id;
    }

    // propriété
    public int OrderNumber
    {
        get { return this.orderNumber; }
        set { this.orderNumber = value; }
    }
    public double TotalAmount
    {
        get { return this.totalAmount; }
        set { this.totalAmount = value; }
    }
    public bool IsPaid
    {
        get { return this.isPaid; }
        set { this.isPaid = value; }
    }
    public Customer Customer
    {
        get { return this.customer; }
        set { this.customer = value; }
    }
    public List<Product> Products
    {
        get { return this.products; }
        set { this.products = value; }
    }
    public int Id
    {
        get { return this.id; }
    }

    public void Display()
    {
        Console.WriteLine($"Numéro de commande: {this.orderNumber}");
        Console.WriteLine($"Montant total: {this.totalAmount}");
        if (this.isPaid)
        {
            Console.WriteLine("Statut: Payée");
        }
        else
        {
            Console.WriteLine("Statut: Non payée");
        }
        Console.WriteLine();
        Console.WriteLine(" ----- Détail du client ----- ");
        Console.WriteLine($"Nom: {this.customer.FirstName} {this.customer.LastName}");
        Console.WriteLine($"Email: {this.customer.Email}");
        Console.WriteLine(" -----------------------------");
        Console.WriteLine();
        Console.WriteLine(" ----- Détail des produits ----- ");
        foreach (Product product in this.products)
        {
            Console.WriteLine($"Nom du produit: {product.Name}");
            Console.WriteLine($"Prix du produit: {product.Price}");
            Console.WriteLine($"Fournisseur du produit: {product.Supplier.Name}");
            Console.WriteLine();
        }
         Console.WriteLine(" -----------------------------");
    }

    public void AddProduct(Product product)
    {
        this.products.Add(product);
        this.totalAmount += product.Price;
    }

    public void DispayProducts()
    {
        Console.WriteLine(" ----- Détail des produits ----- ");
        foreach (Product product in this.products)
        {
            Console.WriteLine($"Nom du produit: {product.Name}");
            Console.WriteLine($"Prix du produit: {product.Price}");
            Console.WriteLine($"Fournisseur du produit: {product.Supplier.Name}");
            Console.WriteLine();
        }
         Console.WriteLine(" -----------------------------");
    }

    public void CalculateTotal()
    {
        double total = 0.0;
        foreach (Product product in this.products)
        {
            total += product.Price;
        }
        this.totalAmount = total;
        Console.WriteLine($"Le montant total de la commande est: {this.totalAmount}");
    }
}