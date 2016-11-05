using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Score_4
{
    public partial class MainWindow : Window
    {
        private int[,] Cells;
        private State s;
        Player cpuPlayer; 

        public MainWindow()
        {
            InitializeComponent();
            //////
            this.s = new State();
            //////
            this.Cells = s.sentDataForGraph(); 
            //////
            this.cpuPlayer = new Player(4, 2);  // 1st param: max depth 2st para : 1 for red 2 for yellow 
         
        }

        void play0(Object sender, EventArgs e)
        {
            s.push(0);
            refreshGraph(s.sentDataForGraph());
            Move pcMove = cpuPlayer.MiniMax(s);
            s.push(pcMove.getCol());
            refreshGraph(s.sentDataForGraph());
        }
        void play1(Object sender,EventArgs e)
        {
            s.push(1);
            refreshGraph(s.sentDataForGraph());
            Move pcMove = cpuPlayer.MiniMax(s);
            s.push(pcMove.getCol());
            refreshGraph(s.sentDataForGraph());
        }
        void play2(Object sender, EventArgs e)
        {
            s.push(3);
            refreshGraph(s.sentDataForGraph());
            Move pcMove = cpuPlayer.MiniMax(s);
            s.push(pcMove.getCol());
            refreshGraph(s.sentDataForGraph());
        }
        void play3(Object sender,EventArgs e)
        {
            s.push(3);
            refreshGraph(s.sentDataForGraph());
            Move pcMove = cpuPlayer.MiniMax(s);
            s.push(pcMove.getCol());
            refreshGraph(s.sentDataForGraph());
        }
        void play4(Object sender,EventArgs e)
        {
            s.push(4);
            refreshGraph(s.sentDataForGraph());
            Move pcMove = cpuPlayer.MiniMax(s);
            s.push(pcMove.getCol());
            refreshGraph(s.sentDataForGraph());
        }
        void play5(Object sender, EventArgs e)
        {
            s.push(5);
            refreshGraph(s.sentDataForGraph());
            Move pcMove = cpuPlayer.MiniMax(s);
            s.push(pcMove.getCol());
            refreshGraph(s.sentDataForGraph());
        }
        void play6(Object sender,EventArgs e)
        {
            s.push(6);
            refreshGraph(s.sentDataForGraph());
            Move pcMove = cpuPlayer.MiniMax(s);
            s.push(pcMove.getCol());
            refreshGraph(s.sentDataForGraph());
        }
        public void refreshGraph(int [,] Cells)//den vlepetai alla variemai na asxolithw allo 
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (Cells[i, j] == 0)
                        continue;
                    else if (Cells[i, j] == 1)
                    {
                        
                    }
                        //.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                    else if (Cells[i, j] == 2) { }


                }
            }
        }



    }
}
