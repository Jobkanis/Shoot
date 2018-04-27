using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot
{
    abstract class MonoList<S>: MonoObject
    {
        protected List<S> elements;

        public MonoList(MainGameFactory mainGameFactory): base(mainGameFactory)
        {
            this.elements = new List<S>();
        }

        public List<S> getList()
        {
            return elements;
        }

        public void Remove(S obj) {
            elements.Remove(obj);
        }
         
        public void Add(S obj) {
            elements.Add(obj);
        }
    }
}
