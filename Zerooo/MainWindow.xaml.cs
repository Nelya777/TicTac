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


namespace Zerooo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String t = "";

        Random rnd = new Random();

        int [] array = new int [9];
        Button[] btn = new Button[9];

        public MainWindow()
        {
            InitializeComponent();

            if (rnd.Next(1, 10) <= 5)
            {
                t = "Крестики";
                label1.Content = "Ходят X";
            }
            else
            {
                t = "Ходят 0";
                label1.Content = "Ходят 0";
            }

            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (t == "Крестики")
            {
                for(int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Content = "X";
                        label1.Content = "Ходят 0";
                        t = "1";
                        btn[i].IsEnabled = false;
                        array[i] = 1;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < btn.Length; i++)
                {
                    if (sender == btn[i])
                    {
                        btn[i].Content = "0";
                        label1.Content = "Ходят X";
                        t = "Крестики";
                        btn[i].IsEnabled = false;
                        array[i] = 2;
                        break;
                    }
                }
            }

            if (array[0]==1 && array[1] == 1 && array[2] == 1)
            {
                btn[0].Foreground = new SolidColorBrush(Colors.Green);
                btn[1].Foreground = new SolidColorBrush(Colors.Green);
                btn[2].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

           else if (array[3] == 1 && array[4] == 1 && array[5] == 1)
            {
                btn[3].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[5].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

            else if (array[6] == 1 && array[7] == 1 && array[8] == 1)
            {
                btn[6].Foreground = new SolidColorBrush(Colors.Green);
                btn[7].Foreground = new SolidColorBrush(Colors.Green);
                btn[8].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

            else if (array[0] == 1 && array[3] == 1 && array[6] == 1)
            {
                btn[0].Foreground = new SolidColorBrush(Colors.Green);
                btn[3].Foreground = new SolidColorBrush(Colors.Green);
                btn[6].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

            else if (array[1] == 1 && array[4] == 1 && array[7] == 1)
            {
                btn[1].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[7].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

            else if (array[2] == 1 && array[5] == 1 && array[8] == 1)
            {
                btn[2].Foreground = new SolidColorBrush(Colors.Green);
                btn[5].Foreground = new SolidColorBrush(Colors.Green);
                btn[8].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

            else if (array[0] == 1 && array[4] == 1 && array[8] == 1)
            {
                btn[0].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[8].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

            else if (array[2] == 1 && array[4] == 1 && array[6] == 1)
            {
                btn[2].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[6].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли крестики";
            }

            else if(array[0] == 2 && array[1] == 2 && array[2] == 2)
            {
                btn[0].Foreground = new SolidColorBrush(Colors.Green);
                btn[1].Foreground = new SolidColorBrush(Colors.Green);
                btn[2].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }

            else if (array[3] == 2 && array[4] == 2 && array[5] == 2)
            {
                btn[3].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[5].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }

            else if (array[6] == 2 && array[7] == 2 && array[8] == 2)
            {
                btn[6].Foreground = new SolidColorBrush(Colors.Green);
                btn[7].Foreground = new SolidColorBrush(Colors.Green);
                btn[8].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }

            else if (array[0] == 2 && array[3] == 2 && array[6] == 2)
            {
                btn[0].Foreground = new SolidColorBrush(Colors.Green);
                btn[3].Foreground = new SolidColorBrush(Colors.Green);
                btn[6].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }

            else if (array[1] == 2 && array[4] == 2 && array[7] == 2)
            {
                btn[1].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[7].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }

            else if (array[2] == 2 && array[5] == 2 && array[8] == 2)
            {
                btn[2].Foreground = new SolidColorBrush(Colors.Green);
                btn[5].Foreground = new SolidColorBrush(Colors.Green);
                btn[8].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }

            else if (array[0] == 2 && array[4] == 2 && array[8] == 2)
            {
                btn[0].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[8].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }

            else if (array[2] == 2 && array[4] == 2 && array[6] == 2)
            {
                btn[2].Foreground = new SolidColorBrush(Colors.Green);
                btn[4].Foreground = new SolidColorBrush(Colors.Green);
                btn[6].Foreground = new SolidColorBrush(Colors.Green);

                for (int i = 0; i < btn.Length; i++)
                {
                    btn[i].IsEnabled = false;
                }
                button10.IsEnabled = true;
                label1.Content = "Выиграли нолики";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < btn.Length; i++)
            {
                array[i] = 0;
                btn[i].Content = "";

                if (rnd.Next(1, 10) <= 5)
                {
                    t = "Крестики";
                    label1.Content = "Ходят X";
                }
                else
                {
                    t = "Ходят 0";
                    label1.Content = "Ходят 0";
                }

                btn[i].IsEnabled = true;
                btn[i].Foreground = new SolidColorBrush(Colors.Black);
            }
        }
    }
}
