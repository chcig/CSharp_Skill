using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac.DesignPattern.Create.FactoryMethod
{
    public abstract class PipeItemFactory
    {
        public abstract PipeItem CreatePipeItem();
        public void Operation()
        {
            PipeItem item = CreatePipeItem();
            item.Draw();
        }
    }
}
