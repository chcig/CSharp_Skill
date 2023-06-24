using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac.DesignPattern.Create.FactoryMethod
{
    public abstract class PipeItem : IShape
    {
        public abstract PipeItem Clone();
        public virtual void Draw()
        {
            Console.WriteLine("{0} Draw",this.GetType());
        }
    }
}
