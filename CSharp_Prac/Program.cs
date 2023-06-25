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
using CSharp_Prac.DataStructure.LinkedList;

class Program
{
    static void Main(string[] args)
    {
        eList<int> lst = new eList<int>();
        lst.Add(4);
        lst.Add(5);
        lst.Add(6);
        lst.Add(7);
        lst.Add(8);
        lst.getAt(1);
        lst.removeAt(1);
        lst.getAt(1);
        lst.Display();
    }
}