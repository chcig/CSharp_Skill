using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac.DesignPattern.Create.FactoryMethod
{
    public class PipeJoint : PipeItem
    {
        public override void Draw()
        {
            Console.WriteLine("{0} Draw", this.GetType());
        }
        public override PipeItem Clone()
        {
            return (PipeItem)this.MemberwiseClone();
        }
    }
}
