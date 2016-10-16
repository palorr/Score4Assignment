using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score_4
{
    class State
    {
        private int[,] Cells { get; set; }
        private string[,] CellsNames;
        //
        public State()//ctor1
        {
            Cells = null;
            //
            for (int i = 0; i < 7; i++)//row
            {
                for (int j = 0; j < 7; j++)//col
                {
                    CellsNames[i, j] = "c" + i + j; 
                }
            }
            //
        }
        //
        public void push(int col)//col=0-6 για να μην εχουμε 7 διαφορετικες που δεν σου αρεσε 
        {

        }
        

    }
}
