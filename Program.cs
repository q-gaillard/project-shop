using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Diagnostics.Tracing;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace projet_C_;

class Product
{
    private string name;
    private double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public Product()
    {
        this.name = "";
        this.price = 0.0;
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


    public void Display()
    {
        Console.WriteLine($"nom du produit: {this.name}");
        Console.WriteLine($"Prix du produit: {this.price}");
    }
}

class Customer
{
    private string firstName;
    private string lastName;

    private string email;

    public Customer(string firstName, string lastName, string email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
    }

    public Customer()
    {
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

    // propriété
    public string firstNameName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }
    public string lastNameName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }
    public string emailName
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public void Display()
    {
        Console.WriteLine($"nom du client: {this.firstName} {this.lastName}");
        Console.WriteLine($"Email du client: {this.email}");
    }
}

class Order
{
    private int orderNumber;
    private double totalAmount;
    private bool isPaid;

    public Order(int orderNumber, double totalAmount, bool isPaid)
    {
        this.orderNumber = orderNumber;
        this.totalAmount = totalAmount;
        this.isPaid = isPaid;
    }

    public Order()
    {
        this.orderNumber = 0;
        this.totalAmount = 0.0;
        this.isPaid = false;
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
    }
}

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

class Supplier
{
    private string name;
    private string city;
    private int phone;

    public Supplier(string name, string city, int phone)
    {
        this.name = name;
        this.city = city;
        this.phone = phone;
    }

    public Supplier()
    {
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
class Program
{
    static void Main(string[] args)
    {
        // crée le premier produit en uttilisant les getters et les setters
        Product product1 = new Product();
        product1.setName("Laptop");
        product1.setPrice(1200);
        Console.WriteLine($"produit 1 : {product1.getName()} , {product1.getPrice()}");

        // crée un client en utilisant les getters et les setters
        Customer customer1 = new Customer();
        customer1.setFirstName("Alice");
        customer1.setLastName("Martin");
        customer1.setEmail("alice@email.com");
        Console.WriteLine($"client 1 : {customer1.getFirstName()} {customer1.getLastName()}, {customer1.getEmail()}");

        // crée une commande en utilisant les getters et les setters
        Order order1 = new Order();
        order1.setOrderNumber(1001);
        order1.setTotalAmount(1200);
        order1.setIsPaid(true);
        Console.WriteLine($"commande 1 : {order1.getOrderNumber()} , total amount: {order1.getTotalAmount()} , is paid: {order1.getIsPaid()}");

        // crée un objet en utilisant les propriétés
        Item item1 = new Item();
        item1.Name = "Smartphone";
        item1.Price = 800;
        item1.Quantity = 25;
        Console.WriteLine($"objet 1 : {item1.Name} , {item1.Price} , {item1.Quantity}");

        // crée un fournisseur en utilisant les propriétés
        Supplier supplier1 = new Supplier();
        supplier1.Name = "TechSuppliy";
        supplier1.City = "Paris";
        supplier1.Phone = 0102030405;
        Console.WriteLine($"fournisseur 1 : {supplier1.Name} , ville: {supplier1.City} , téléphone: {supplier1.Phone}");

        // crée 3 catégories en utilisant les propriétés
        Category category1 = new Category();
        Category category2 = new Category();
        Category category3 = new Category();

        category1.Name = "Électronics";
        category1.Description = "Electronic devices";

        category2.Name = " Books";
        category2.Description = " Books and literature";

        category3.Name = " Clothing";
        category3.Description = "Clothes and accessories";

        Console.WriteLine($"catégorie 1 : {category1.Name} , description: {category1.Description}");
        Console.WriteLine($"catégorie 2 : {category2.Name} , description: {category2.Description}");
        Console.WriteLine($"catégorie 3 : {category3.Name} , description: {category3.Description}");

        // modfication de la commande 1 en utilisant les propriétés
        order1 = new Order();
        order1.OrderNumber = 1001;
        order1.TotalAmount = 1200;
        order1.IsPaid = true;
        Console.WriteLine($"commande 1 : {order1.OrderNumber} , total amount: {order1.TotalAmount} , is paid: {order1.IsPaid}");
    }
}
