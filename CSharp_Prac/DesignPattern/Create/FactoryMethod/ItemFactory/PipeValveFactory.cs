using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac.DesignPattern.Create.FactoryMethod
{
    public class PipeValveFactory : PipeItemFactory
    {
        public override PipeItem CreatePipeItem()
        {
            return new PipeValve();
        }
    }
}
