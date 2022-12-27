using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    /*
   {
    Maths ObjMaths = new Maths();
    Thread t1 = new Thread(ObjMaths.Divide);
    t1.Start();//Child thread
    ObjMaths.Divide();//Main thread
}
class Maths
{
    public int Num1, Num2;
    Random o = new Random();
    public void Divide()
    {
        for (int i = 0; i < 1000000; i++)
        {
            //lock (this)
            //{
            Monitor.Enter(this);
            Num1 = o.Next(1, 2); //1 to 2
            Num2 = o.Next(1, 2);//1 to 2
            int result = Num1 / Num2;//Divide
            Num1 = 0;
            Num2 = 0;
            //}
            Monitor.Exit(this);
        }
    }
}
    */
}
