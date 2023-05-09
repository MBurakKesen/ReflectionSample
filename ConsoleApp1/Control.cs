using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    public static class Control
    {
        public static bool Check(Person person)
        {

            Type type = person.GetType();

            foreach (var item in type.GetProperties())// field erişim belirleyicilerinin hata vermesini engeller
            {
                object[] attributes=item.GetCustomAttributes(typeof(ZorunluAttribute), true);
                if(attributes.Length != 0) 
                {
                    object value=item.GetValue(person);

                    if (value is null)
                    {
                        return false;
                    }
                }
              
            }
            return true;
        }
    }
}
