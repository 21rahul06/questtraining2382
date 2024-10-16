using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8inventorymanagement
{
    internal class Program
    {
        static List<Dictionary<string, string>> inventory = new List<Dictionary<string, string>>();

        // Function to add a new product to the inventory
        static void AddProduct()
        {
            var product = new Dictionary<string, string>();

            Console.WriteLine("Enter Product ID: ");
            string productId = Console.ReadLine();

            // Check if the product already exists 
            bool exists = false;

            foreach (var p in inventory)
            {
                if (p["ProductID"] == productId)
                {
                    Console.WriteLine("Product with this ID already exists. Please use a unique Product ID.\n");
                    exists = true; 
                    break; 
                }
            }

            if (!exists) 
            {
                product["ProductID"] = productId;

                Console.WriteLine("Enter Product Name: ");
                product["Name"] = Console.ReadLine();

                Console.WriteLine("Enter Product Price: ");
                product["Price"] = Console.ReadLine();

                Console.WriteLine("Enter Product Stock: ");
                product["Stock"] = Console.ReadLine();

                // Add the product to the inventory list
                inventory.Add(product);
                Console.WriteLine($"Product '{product["Name"]}' added successfully with ID: {productId}\n");
            }
        }
        static void UpdateStock()
        {
            Console.WriteLine("Enter Product ID to update stock: ");
            string productId = Console.ReadLine();

            
            bool productFound = false;

            foreach (var product in inventory)
            {
                if (product["ProductID"] == productId)
                {
                    //Update stock
                    Console.WriteLine("Enter new stock quantity: ");
                    product["Stock"] = Console.ReadLine();
                    Console.WriteLine("Stock updated successfully!\n");
                    productFound = true;
                    break;
                }
            }
        
            if (!productFound)
            {
                Console.WriteLine("Product not found!\n");
            }
        }
        static void GetProductDetails()
        {
            Console.WriteLine("Enter Product ID to retrieve details: ");
            string productId = Console.ReadLine();

            // Check if the product exists using a foreach loop
            bool productFound = false; 

            foreach (var product in inventory)
            {
                if (product["ProductID"] == productId)
                {
                    Console.WriteLine("Product Details:");
                    Console.WriteLine($"ID: {product["ProductID"]}");
                    Console.WriteLine($"Name: {product["Name"]}");
                    Console.WriteLine($"Price: {product["Price"]}");
                    Console.WriteLine($"Stock: {product["Stock"]}\n");
                    productFound = true; 
                    break; 
                }
            }
            if (!productFound)
            {
                Console.WriteLine("Product not found!\n");
            }
        }
        static void GetLowStockProducts()
        {

            Console.WriteLine("Enter the stock threshold: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int threshold))
            {
                // Use LINQ to filter products with stock below the threshold
                var lowStockProducts = inventory.Where(product => int.Parse(product["Stock"]) < threshold).ToList();

                // Check if any low stock products exist
                if (lowStockProducts.Any())
                {
                    Console.WriteLine("Low Stock Products:");
                    foreach (var product in lowStockProducts)
                    {
                        Console.WriteLine($"ID: {product["ProductID"]}, Name: {product["Name"]}, Stock: {product["Stock"]}");
                    }
                }
                else
                {
                    Console.WriteLine("No low stock products found.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }

        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("Enter your choice: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductDetails();
                        break;
                    case "4":
                        GetLowStockProducts();
                        break;
                    default:
                        Console.WriteLine("Invalid option! Try again.\n");
                        break;
                }
            }
        }
    }
}
