using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_ClassProductInUse
{
    public static class ListExtensions
    {
        public static T Pop<T>(this List<T> newCollection, int index)
        {
            T itemAtIndex = newCollection[index];
            newCollection.RemoveAt(index);
            return itemAtIndex;
        }
    }
}
