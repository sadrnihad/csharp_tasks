using System.IO.Pipes;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //for (int i = 0; i < 5; i++) 
            //{
            //    Console.Write($"ededi {i + 1} daxil et: ");
            //    numbers[i] = int.Parse(Console.ReadLine());

            //}

            //Array.Sort(numbers);
            //Console.Write("Artan sira ile: ");
            //foreach (int n in numbers)
            //    Console.Write(n + " ");

            ////bir arrayi tersine cevir
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, };
            //Array.Reverse(arr);
            //Console.Write(string.Join(", ", arr));


            ////en kicik ve en boyuk ededi tap.

            //int[] nums = { 5, 4, 7, 2, 9 };
            //int min = nums.Min();
            //int max = nums.Max();
            //Console.WriteLine($"En kicik eded: {min}, En boyuk eded: {max}");

            ////istifadeciye daxil edilen ededin olub olmadigini yoxlayan program.
            //int[] arr0 = { 2, 4, 5, 7, 9 };
            //Console.Write("ededi daxil edin: ");
            //int search = int.Parse(Console.ReadLine());

            //if (arr0.Contains(search)) 
            //{
            //    Console.WriteLine("Eded tapildi!");
            //}
            //else
            //{
            //    Console.WriteLine("Eded Tapilmadi");
            //}

            ////arrayin kopyasinin hazirlanmasi.

            //int[] first = { 1, 2, 3, 4, 5, 6, 7 };
            //int[] second = new int[first.Length];

            //Array.Copy(first, second, first.Length);
            //Array.Sort(second);

            //Console.WriteLine("orginal: " + string.Join(", ", first));
            //Console.WriteLine("Copy: " + string.Join(", ", second));

            ////verilen arrayin muyyen hissesin sifirlanmasi.

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //Array.Clear(arr1, 3, 2);
            //Console.WriteLine(string.Join(", ", arr1));


            ////bir arrayin olcusunu artir.

            //int[] arr2 = { 1, 2, 3, 4, 5, 6, 7};
            //Array.Resize(ref arr2, 9);
            //arr2[7] = 8;
            //arr2[8] = 9;
            //Console.WriteLine(string.Join(", ", arr2));

            ////adlari elifba sirasi ile duzmek

            //string[] names = { "omar", "ali", "nigar", "samxal" };
            //Array.Sort(names);
            //Console.WriteLine(", ", names);



            //student student = new student();
            //student.name = "Samxal";
            //student.age = 18;
            //student.grade = 94.4;

            //student student2 = new student();
            //student2.name = "Ayka";
            //student2.age = 24;
            //student2.grade = 100;

            //student student3 = new student();
            //student3.name = "Murad";
            //student3.age = 43;
            //student3.grade = 45.2;


            //student.ShowInfo();
            //student2.ShowInfo();
            //student3.ShowInfo();


            //Car car = new Car("BMW", "M5", 2020);
            //Car car2 = new Car("Porsche", "911", 2015);

            //car.Display();
            //car2.Display();

            //rectangle rectangle = new rectangle();
            //rectangle.width = 6;
            //rectangle.height = 8;

            //Console.WriteLine("Sahe: " + rectangle.Area());


            //BankAccount account = new BankAccount();
            //account.owner = "Nihad";
            //account.balance = 1000;

            //account.Deposit(500);
            //account.Withdraw(1200);
            //account.Withdraw(1500);


            //book book = new book("Game of Thrones", "Nihadov", 329);
            //book book1 = new book("necesen", "nihadov", 342);

            //book.GetInfo();
            //book1.GetInfo();

            //Task 1:

            Human human = new Human();
            human.name = "samxal";
            human.surname = "samaxalov";
            human.age = 25;
            human.gender = "Male";
            human.nationality = "azeri";

            human.ShowInfo();


           




;


           
        }
    }
}
