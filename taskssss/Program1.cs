using System.IO.Pipes;

namespace ConsoleApp3
{
    internal class Program1
    {
        static List<string> FilterbyPrice(Device[] products, double price)
        {
            List<string> result = new List<string>();

            foreach (var item in products)
            {
                if (item.salePrice > price)
                {
                    result.Add($"{item.brand} {item.model} - {item.salePrice} AZN");
                }
            }

            return result;
        }

       
        static int FilterbyName(Device[] products, string name)
        {
            int count = 0;

            foreach (var item in products)
            {
                if (item.brand.ToLower() == name.ToLower())
                {
                    count++;
                }
            }

            return count;
        }


        static void Main(string[] args)
        {
          
            Phone phone = new Phone()
            {
                brand = "iPhone",
                model = "14 Pro",
                screenSize = 6.1,
                batteryLevel = 80,
                price = 1800,
                salePrice = 2200,
                saleCount = 3,
                IsSmart = true
            };

            Phone phone1 = new Phone()
            {
                brand = "Nokia",
                model = "3310",
                screenSize = 2.4,
                batteryLevel = 100,
                price = 100,
                salePrice = 90,
                saleCount = 5,
                IsSmart = false
            };

            Laptop laptop = new Laptop()
            {
                brand = "Asus",
                model = "TUF Gaming",
                screenSize = 15.6,
                batteryLevel = 60,
                price = 1500,
                salePrice = 2000,
                saleCount = 2,
                isRGBkeyboard = true
            };

            Laptop laptop1 = new Laptop()
            {
                brand = "HP",
                model = "Pavilion",
                screenSize = 14.0,
                batteryLevel = 70,
                price = 900,
                salePrice = 850,
                saleCount = 1,
                isRGBkeyboard = false
            };

            Device[] products = { phone1, phone, laptop1, laptop };

          
            foreach (var item in products)
            {
                Console.WriteLine("\n==========================");
                item.DisplayDetails();
                item.DisplayBatteryLevel();
                item.CalculateProfit();
            }

           
            Console.WriteLine("\n==========================");
            Console.WriteLine("Qiyməti 1000 AZN-dən yuxarı olan məhsullar:");
            var expensive = FilterbyPrice(products, 1000);
            foreach (var name in expensive)
            {
                Console.WriteLine(name);
            }

            
            Console.WriteLine("\n'iPhone' məhsullarının sayı: " + FilterbyName(products, "iPhone"));
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Human omer = new Human("Nihad", "Sadraddinbayli", 19, "Kisi", "alman", 2006);
                Console.WriteLine("Obyekt 1 Məlumatları:");
                omer.GetFullName();
                omer.GetBirthYear();
            }
        }
    }
}
        
