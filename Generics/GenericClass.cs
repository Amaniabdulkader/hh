using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericClass<T> 
    {
        public GenericClass(T item ,string name, string description )
        {
            Item = item;
            Name = name;
            Description = description;

            }
        public string Name { get; set; }
        public string Description { get; set; }
        public T Item { get; set; }
    }
}
