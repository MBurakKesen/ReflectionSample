using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [AttributeUsage(AttributeTargets.Field|
        AttributeTargets.Property,
        AllowMultiple = false
        )]
    public class ZorunluAttribute : Attribute
    {
    }
}
