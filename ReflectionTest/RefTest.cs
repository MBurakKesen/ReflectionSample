using System.Reflection;

namespace ReflectionTest
{
    public class RefTest
    {
        public static void Execute()
        {

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type types = assembly.GetType("ReflectionTest.MyClass");
            var ins = (MyClass)Activator.CreateInstance(types);
            //getPropWithAssemblyReferences(types, ins);
            //getMethodWithAssembly(types, ins);

        }
        private static void getPropWithAssemblyReferences(Type types, MyClass? ins)
        {
            ins.FirstName = "Burak";
            var prop = types.GetProperty("FirstName");
            prop.SetValue(ins, "Alex");
            Console.WriteLine(ins.FirstName);
        }

        private static void getMethodWithAssembly(Type types, object? ins)
        {
            var method = types.GetMethod("write");
            object[] param = { "merhaba" };
            method.Invoke(ins, param);
        }
    }
    public class MyClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public void write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
