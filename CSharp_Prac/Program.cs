using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace CSharp_Prac
//{
//    class Program
//    {
//        private int Teariars { get; set; }
//        private static MyButton btn { get; set; }
//        private static Button_Inheritance btn_Inher { get; set; }
//        public Program()
//        {
//            Teariars = 0;
//        }
//        static void Main(string[] args)
//        {
//            Program temp;
//            {
//                temp = new Program();
//            }
//            if (temp.Teariars == 0)
//            {
//                btn = new MyButton();
//            }
//            else
//            {
//                btn.ClickCount = 10;
//                btn_Inher = new Button_Inheritance(5);
//                btn_Inher.SetItemValue(btn);
//            }
//        }
//    }
//}

using CSharp_Prac.DesignPattern.Create.FactoryMethod;
using CSharp_Prac.DesignPattern.Create.Prototype;

class Program
{
    static void Main(string[] args)
    {
        PipeItemFactory GaugeFactory = new PipeGaugeFactory();
        GaugeFactory.Operation();

        PipeItemFactory JointFactory = new PipeJointFactory();
        JointFactory.Operation();

        PipeItemFactory InjectorFactory = new PipeInjectorFactory();
        InjectorFactory.Operation();

        PipeItemFactory ValveFactory = new PipeValveFactory();
        ValveFactory.Operation();

        PipeItemManager manager = new PipeItemManager(GaugeFactory);
        PipeGauge cloneGauge = (PipeGauge)manager.CreatePipeItem();
    }
}