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

namespace Cross
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int fighter;
        private static List<int> NumList = new List<int>();
        private int Resmove;
        public MainWindow()
        {
            InitializeComponent();
            disableField();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            RestartBT.IsEnabled = true;
            NgameBT.IsEnabled = true;
            
            switch (fighter)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "O");
                    fighter = 1;
                    MoveTB.Text = "Move: X go";
                    NumList.Add(1);
                    if (NumList.Count != 9)
                    {
                        Robot();
                        fighter = 0;
                        MoveTB.Text = "Move: O go";
                    }
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "X");
                    fighter = 0;
                    MoveTB.Text = "Move: O go";
                    NumList.Add(1);
                    if (NumList.Count != 9)
                    {
                        Robot();
                        fighter = 1;
                        MoveTB.Text = "Move: X go";
                    }
                    break;
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            vincheker();
        }
        private void vincheker()
        {
            if (NumList.Count == 9)
            {
                WinnerTB.Text = "Winner: Nychya";
            }
            else
            {
                if (but1.Content == but2.Content && but2.Content == but3.Content)
                {
                    vinchekPro(but1);
                }
                if (but4.Content == but5.Content && but5.Content == but6.Content)
                {
                    vinchekPro(but4);
                }
                if (but7.Content == but8.Content && but8.Content == but9.Content)
                {
                    vinchekPro(but7);
                }
                if (but1.Content == but4.Content && but4.Content == but7.Content)
                {
                    vinchekPro(but1);
                }
                if (but2.Content == but5.Content && but5.Content == but8.Content)
                {
                    vinchekPro(but2);
                }
                if (but3.Content == but6.Content && but6.Content == but9.Content)
                {
                    vinchekPro(but3);
                }
                if (but1.Content == but5.Content && but5.Content == but9.Content)
                {
                    vinchekPro(but1);
                }
                if (but3.Content == but5.Content && but5.Content == but7.Content)
                {
                    vinchekPro(but3);
                }
            }
            
           
        }
        private void vinchekPro(Button but)
        {
            if (but.Content.ToString() != "")
            {
                if (but.Content.ToString() == "O")
                {
                    WinnerTB.Text = "Winner: Player O";
                    disableField();
                    RestartBT.IsEnabled = true;
                    NgameBT.IsEnabled = true;
                }
                else
                {
                    WinnerTB.Text = "Winner: Player X";
                    disableField();
                    RestartBT.IsEnabled = true;
                    NgameBT.IsEnabled = true;
                }
            }
        }

        private void XButton_Click(object sender, RoutedEventArgs e)
        {
            fighter = 1;
            Resmove = fighter;
            MoveTB.Text = "Move: X go";
            XButtom.IsEnabled = false;
            Obutton.IsEnabled = false;
            enableField();
        }

        private void Obutton_Click(object sender, RoutedEventArgs e)
        {
            fighter = 0;
            Resmove = fighter;
            MoveTB.Text = "Move: O go";
            Obutton.IsEnabled = false;
            XButtom.IsEnabled = false;
            enableField();
        }

        private void RestartBT_Click(object sender, RoutedEventArgs e)
        {
            fighter = Resmove;
            MoveTB.Text = "";
            WinnerTB.Text = "";
            enableField();
            clearField();
            NumList.Clear();
            Obutton.IsEnabled = false;
            XButtom.IsEnabled = false;
        }
        private void NgameBT_Click(object sender, RoutedEventArgs e)
        {
            MoveTB.Text = "";
            WinnerTB.Text = "";
            disableField();
            clearField();
            NumList.Clear();
            Obutton.IsEnabled = true;
            XButtom.IsEnabled = true;
        }
        private void Robot()
        {
            Random point = new Random();
            bool stop = true;
            while (stop)
            {
                int step = point.Next(1, 9);
                switch (step)
                {
                    case 1:
                        if (but1.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but1.Content = "O";
                            }
                            else
                            {
                                but1.Content = "X";
                            }
                            NumList.Add(1);
                            but1.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 2:
                        if (but2.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but2.Content = "O";
                            }
                            else
                            {
                                but2.Content = "X";
                            }
                            NumList.Add(1);
                            but2.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 3:
                        if (but3.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but3.Content = "O";
                            }
                            else
                            {
                                but3.Content = "X";
                            }
                            NumList.Add(1);
                            but3.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 4:
                        if (but4.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but4.Content = "O";
                            }
                            else
                            {
                                but4.Content = "X";
                            }
                            NumList.Add(1);
                            but4.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 5:
                        if (but5.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but5.Content = "O";
                            }
                            else
                            {
                                but5.Content = "X";
                                NumList.Add(1);
                            }
                            NumList.Add(1);
                            but5.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 6:
                        if (but6.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but6.Content = "O";
                            }
                            else
                            {
                                but6.Content = "X";
                            }
                            NumList.Add(1);
                            but6.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 7:
                        if (but7.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but7.Content = "O";
                            }
                            else
                            {
                                but7.Content = "X";
                            }
                            NumList.Add(1);
                            but7.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 8:
                        if (but8.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but8.Content = "O";
                            }
                            else
                            {
                                but8.Content = "X";
                            }
                            NumList.Add(1);
                            but8.IsEnabled = false;
                            stop = false;
                        }
                        break;
                    case 9:
                        if (but9.Content.ToString() == "")
                        {
                            if (fighter == 0)
                            {
                                but9.Content = "O";
                            }
                            else
                            {
                                but9.Content = "X";
                            }
                            NumList.Add(1);
                            but9.IsEnabled = false;
                            stop = false;
                        }
                        break;
                }
            }
        }
        private void disableField()
        {
            but1.IsEnabled = false;
            but2.IsEnabled = false;
            but3.IsEnabled = false;
            but4.IsEnabled = false;
            but5.IsEnabled = false;
            but6.IsEnabled = false;
            but7.IsEnabled = false;
            but8.IsEnabled = false;
            but9.IsEnabled = false;
            RestartBT.IsEnabled = false;
            NgameBT.IsEnabled = false;
        }
        private void clearField()
        {
            but1.Content = "";
            but2.Content = "";
            but3.Content = "";
            but4.Content = "";
            but5.Content = "";
            but6.Content = "";
            but7.Content = "";
            but8.Content = "";
            but9.Content = "";
        }

        private void enableField()
        {
            but1.IsEnabled = true;
            but2.IsEnabled = true;
            but3.IsEnabled = true;
            but4.IsEnabled = true;
            but5.IsEnabled = true;
            but6.IsEnabled = true;
            but7.IsEnabled = true;
            but8.IsEnabled = true;
            but9.IsEnabled = true;
        }
    }
}
