using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharp_Prac.Interface.TCP_IP;
using CSharp_Prac.Thread.Thread;
using CSharp_Prac.Thread.Task;

namespace CSharp_Prac.DesignPattern.Create.StepBuilder
{
    class SystemBuilder
    {
        private System _system;
        public SystemBuilder()
        {
            _system = new System();
        }

        public SystemBuilder Interface1_Init()
        {
            _system.Interface1 = new eSocket();
            return this;
        }
        public SystemBuilder Interface2_Init()
        {
            _system.Interface2 = new eSocket();
            return this;
        }
        public SystemBuilder Interface3_Init()
        {
            _system.Interface3 = new eSocket();
            return this;
        }

        public SystemBuilder Thread1_Init()
        {
            _system.Thread1 = new eThread();
            return this;
        }
        public SystemBuilder Thread2_Init()
        {
            _system.Thread2 = new eThread();
            return this;
        }
        public SystemBuilder Thread3_Init()
        {
            _system.Thread3 = new eThread();
            return this;
        }
        public SystemBuilder Task1_Init()
        {
            _system.Task1 = new eTask();
            return this;
        }
        public SystemBuilder Task2_Init()
        {
            _system.Task2 = new eTask();
            return this;
        }
        public SystemBuilder Task3_Init()
        {
            _system.Task3 = new eTask();
            return this;
        }

        public System Builder()
        {
            return _system;
        }
    }
}
