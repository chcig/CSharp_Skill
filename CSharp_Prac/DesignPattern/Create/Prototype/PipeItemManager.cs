using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Prac.DesignPattern.Create.FactoryMethod;

namespace CSharp_Prac.DesignPattern.Create.Prototype
{
    class PipeItemManager
    {
        private readonly PipeItemFactory _pipeitemfctr;
        public PipeItemManager(PipeItemFactory pipeitemfctr)
        {
            this._pipeitemfctr = pipeitemfctr;
        }
        public PipeItem CreatePipeItem()
        {
            PipeItem prototype = _pipeitemfctr.CreatePipeItem();
            return prototype.Clone();
        }
    }
}
