using System;
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

using CSharp_Prac.DataStructure.Que;

class Program
{
    static void Main(string[] args)
    {
        eQue<int> iQue = new eQue<int>();
        iQue.Enqueue(5);
        iQue.Enqueue(4);
        iQue.Enqueue(3);
        iQue.Enqueue(2);
        iQue.Enqueue(1);

        iQue.Dequeue();
        iQue.display();

        eQue<string> strQue = new eQue<string>();

        strQue.Enqueue("a");
        strQue.Enqueue("b");
        strQue.Enqueue("c");
        strQue.Enqueue("d");
        strQue.Enqueue("e");

        strQue.Dequeue();
        strQue.display();
    }
}