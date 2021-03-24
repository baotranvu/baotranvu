using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendClass
{
    public class ClientList<T> : List<T>
    {
        public EventHandler ClientAddedHandler;
        public new void Add(T item) // "new" to avoid compiler-warnings, because we're hiding a method from base-class
        {
            if (null != ClientAddedHandler)
            {
                ClientAddedHandler(this, null);
            }
            base.Add(item);
        }
    }
}
