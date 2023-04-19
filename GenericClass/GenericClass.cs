using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class GenericClass<T> where T : struct
    {

        private List<T> list = new List<T>();
     
       
        public void AddList(T item)
        {
            list.Add(item);
        }
        public T showdata(int itemIndex)
        {

                return list[itemIndex];
          } 

        public List<T> getSortList()
        {
            list.Sort();
            return list;
        }
    }
}
