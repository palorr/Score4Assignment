using System;
using System.Windows;
using System.Windows.Media;

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
            this.cpuPlayer = new Player(5, 2);  // 1st param: max depth 2st param : 1 for red 2 for yellow 
         
        }

        void play0(Object sender,EventArgs e)
        {
            if (!s.isTerminal())
            {
                s.push(0);
                refreshGraph(s.sentDataForGraph());
                if (!s.isTerminal())
                {
                    Move pcMove = cpuPlayer.MiniMax(s);
                    s.push(pcMove.getCol());
                    refreshGraph(s.sentDataForGraph());
                }
            }
        }
        void play1(Object sender,EventArgs e)
        {
            if (!s.isTerminal())
            {
                s.push(1);
                refreshGraph(s.sentDataForGraph());
                if (!s.isTerminal())
                {
                    Move pcMove = cpuPlayer.MiniMax(s);
                    s.push(pcMove.getCol());
                    refreshGraph(s.sentDataForGraph());
                }
            }
        }
        void play2(Object sender,EventArgs e)
        {
            if (!s.isTerminal())
            {
                s.push(2);
                refreshGraph(s.sentDataForGraph());
                if (!s.isTerminal())
                {
                    Move pcMove = cpuPlayer.MiniMax(s);
                    s.push(pcMove.getCol());
                    refreshGraph(s.sentDataForGraph());
                }
            }
        }
        void play3(Object sender,EventArgs e)
        {
            if (!s.isTerminal())
            {
                s.push(3);
                refreshGraph(s.sentDataForGraph());
                if (!s.isTerminal())
                {
                    Move pcMove = cpuPlayer.MiniMax(s);
                    s.push(pcMove.getCol());
                    refreshGraph(s.sentDataForGraph());
                }
            }
        }
        void play4(Object sender,EventArgs e)
        {
            if (!s.isTerminal())
            {
                s.push(4);
                refreshGraph(s.sentDataForGraph());
                if (!s.isTerminal())
                {
                    Move pcMove = cpuPlayer.MiniMax(s);
                    s.push(pcMove.getCol());
                    refreshGraph(s.sentDataForGraph());
                }
            }
        }
        void play5(Object sender,EventArgs e)
        {
            if (!s.isTerminal())
            {
                s.push(5);
                refreshGraph(s.sentDataForGraph());
                if (!s.isTerminal())
                {
                    Move pcMove = cpuPlayer.MiniMax(s);
                    s.push(pcMove.getCol());
                    refreshGraph(s.sentDataForGraph());
                }
            }
        }
        void play6(Object sender,EventArgs e)
        {
            if (!s.isTerminal())
            {
                s.push(6);
                refreshGraph(s.sentDataForGraph());
                if (!s.isTerminal())
                {
                    Move pcMove = cpuPlayer.MiniMax(s);
                    s.push(pcMove.getCol());
                    refreshGraph(s.sentDataForGraph());
                }
            }
        }
        public void refreshGraph(int [,] Cells)//polu bad practise alla den thn paleuw na asxolithw allo
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (Cells[i, j] == 0)
                        continue;
                    else if (Cells[i, j] == 1)//red
                    {
                        if (i==0 && j==0)
                        {
                            c00.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if(i == 0 && j == 1)
                        {
                            c01.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 0 && j == 2)
                        {
                            c02.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 0 && j == 3)
                        {
                            c03.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 0 && j == 4)
                        {
                            c04.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 0 && j == 5)
                        {
                            c05.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 0 && j == 6)
                        {
                            c06.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 1 && j == 0)
                        {
                            c10.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 1 && j == 1)
                        {
                            c11.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 1 && j == 2)
                        {
                            c12.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 1 && j == 3)
                        {
                            c13.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 1 && j == 4)
                        {
                            c14.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 1 && j == 5)
                        {
                            c15.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 1 && j == 6)
                        {
                            c16.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 2 && j == 0)
                        {
                            c20.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 2 && j == 1)
                        {
                            c21.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 2 && j == 2)
                        {
                            c22.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 2 && j == 3)
                        {
                            c23.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 2 && j == 4)
                        {
                            c24.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 2 && j == 5)
                        {
                            c25.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 2 && j == 6)
                        {
                            c26.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 3 && j == 0)
                        {
                            c30.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 3 && j == 1)
                        {
                            c31.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 3 && j == 2)
                        {
                            c32.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 3 && j == 3)
                        {
                            c33.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 3 && j == 4)
                        {
                            c34.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 3 && j == 5)
                        {
                            c35.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 3 && j == 6)
                        {
                            c36.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 4 && j == 0)
                        {
                            c40.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 4 && j == 1)
                        {
                            c41.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 4 && j == 2)
                        {
                            c42.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 4 && j == 3)
                        {
                            c43.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 4 && j == 4)
                        {
                            c44.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 4 && j == 5)
                        {
                            c45.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 4 && j == 6)
                        {
                            c46.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 5 && j == 0)
                        {
                            c50.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 5 && j == 1)
                        {
                            c51.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 5 && j == 2)
                        {
                            c52.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 5 && j == 3)
                        {
                            c53.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 5 && j == 4)
                        {
                            c54.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 5 && j == 5)
                        {
                            c55.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }
                        else if (i == 5 && j == 6)
                        {
                            c56.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
                            continue;
                        }


                    }
                    /////
                    else if (Cells[i, j] == 2)//yellow
                    {
                        if (i == 0 && j == 0)
                        {
                            c00.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 0 && j == 1)
                        {
                            c01.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 0 && j == 2)
                        {
                            c02.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 0 && j == 3)
                        {
                            c03.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 0 && j == 4)
                        {
                            c04.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 0 && j == 5)
                        {
                            c05.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 0 && j == 6)
                        {
                            c06.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 1 && j == 0)
                        {
                            c10.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 1 && j == 1)
                        {
                            c11.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 1 && j == 2)
                        {
                            c12.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 1 && j == 3)
                        {
                            c13.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 1 && j == 4)
                        {
                            c14.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 1 && j == 5)
                        {
                            c15.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 1 && j == 6)
                        {
                            c16.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 2 && j == 0)
                        {
                            c20.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 2 && j == 1)
                        {
                            c21.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 2 && j == 2)
                        {
                            c22.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 2 && j == 3)
                        {
                            c23.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 2 && j == 4)
                        {
                            c24.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 2 && j == 5)
                        {
                            c25.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 2 && j == 6)
                        {
                            c26.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 3 && j == 0)
                        {
                            c30.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 3 && j == 1)
                        {
                            c31.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 3 && j == 2)
                        {
                            c32.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 3 && j == 3)
                        {
                            c33.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 3 && j == 4)
                        {
                            c34.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 3 && j == 5)
                        {
                            c35.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 3 && j == 6)
                        {
                            c36.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 4 && j == 0)
                        {
                            c40.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 4 && j == 1)
                        {
                            c41.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 4 && j == 2)
                        {
                            c42.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 4 && j == 3)
                        {
                            c43.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 4 && j == 4)
                        {
                            c44.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 4 && j == 5)
                        {
                            c45.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 4 && j == 6)
                        {
                            c46.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 5 && j == 0)
                        {
                            c50.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 5 && j == 1)
                        {
                            c51.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 5 && j == 2)
                        {
                            c52.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 5 && j == 3)
                        {
                            c53.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 5 && j == 4)
                        {
                            c54.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 5 && j == 5)
                        {
                            c55.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                        else if (i == 5 && j == 6)
                        {
                            c56.Fill = new SolidColorBrush(System.Windows.Media.Colors.Yellow);
                            continue;
                        }
                    }
                }
            }
        }

    }
}
