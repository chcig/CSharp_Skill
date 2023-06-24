using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Prac
{
    class Button_Inheritance : MyButton
    {
        public int temp;
        public Button_Inheritance(int nTEMP)
        {
            temp = nTEMP;
        }
        public void SetItemValue(MyButton parant)
        {
            this.temp = parant.ClickCount;
        }
    }
}
