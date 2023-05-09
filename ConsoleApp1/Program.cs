using ReflectionTest;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person { Id = 1,  Address = "Bursa / Osmangazi", City = "Bursa" };
            Person person2 = new Person {  };

            Person[] array= new Person[] { person1, person2 };
            foreach (var item in array)
            {
                if (!Control.Check(item)) {
                    Console.WriteLine("bir hata yakalandı");
                }
            }
         
                
            //RefTest.Execute();
        }
    }
}