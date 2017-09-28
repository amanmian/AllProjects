using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
public class Product
{
    
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public long phone { get; set; }
    public int age { get; set; }

    public static void Main(string[] args)
    {



        var productList =
                new List<Product> {
                    new Product { Id = 1,
                        Name = "John",
                        Email = "john@gmail.com",
                        phone = 789018,
                        age = 39 },
                    new Product { Id = 2, Name = "Chang", Email = "chang@gmail.com", phone = 7684919,age = 17 },
                    new Product { Id = 3, Name = "Anis", Email = "Anis@gmail.com", phone= 1078960, age = 13 },
                    new Product { Id = 4, Name = "Chef ", Email= "Chef@rediffmail.com", phone= 34567322, age = 53 },
                    new Product { Id = 4, Name = "neha ", Email= "neha@rediffmail.com", phone= 3456722, age = 21 },
                    new Product { Id = 4, Name = "medha", Email= "medha@rediffmail.com", phone= 34567422, age = 53 },
                    new Product { Id = 4, Name = "hiamni ", Email= "himani@rediffmail.com", phone= 6, age = 32},
                    new Product { Id = 4, Name = "pooja ", Email= "pooja@rediffmail.com", phone= 3456722, age = 17 },
                    new Product { Id = 4, Name = "akriti", Email= "akriti@rediffmail.com", phone= 3456722, age = 32 },
                    new Product { Id = 4, Name = "astha ", Email= "astha@rediffmail.com", phone= 3456722, age = 45}
            };


        var javaScriptSerializer = new
System.Web.Script.Serialization.JavaScriptSerializer();
        string jsonString = javaScriptSerializer.Serialize(proList);
        Console.WriteLine(jsonString);

        Console.ReadLine();


        // Load object with some sample data
        products company = new products();

        // Pass "company" object for conversion object to JSON string
        string json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(proList);

        // Write that JSON to txt file
        File.WriteAllText(Environment.CurrentDirectory + @"\JSON.json", json);


    }
}

