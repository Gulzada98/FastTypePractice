using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HW_WPF_LayoutAndContainers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in mainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        int capsOnOff = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "Backspace")
            {
                str = (string)(textLabel.Text);
                textLabel.Text = str.Remove(str.Length - 1);
            }
            else if (str == "CapsLock")
            {
                if (capsOnOff == 0)
                {
                    foreach (UIElement el in mainRoot.Children)
                    {
                        if (el is Button && ((string)((Button)el).Content).Length < 2)
                        {
                            //str = (string)((Button)el).Content;
                            ((Button)el).Content = ((string)((Button)el).Content).ToUpperInvariant();
                        }
                    }
                    capsOnOff = 1;
                }
                else if (capsOnOff == 1)
                {
                    foreach (UIElement el in mainRoot.Children)
                    {
                        if (el is Button && ((string)((Button)el).Content).Length < 2)
                        {
                            // str = (string)((Button)el).Content;
                            ((Button)el).Content = ((string)((Button)el).Content).ToLowerInvariant();
                        }
                    }
                    capsOnOff = 0;
                }
            }
            else if (str == "Space")
            {
                textLabel.Text += " ";
            }
            else
            {
                if (str.Length < 2)
                { textLabel.Text += str; }
            }

            if (str == "Start")
            {
                rndText.Text = "asd asd as ger qcs dgtjty kil liu vergewr yr4 hq ecwe e y4 5hg rbgr tjty jt yhe dv dvdfngh mk, hjk";

                
                textLabel.Foreground = Brushes.White;

                textLabel.Text = Convert.ToString( rndText.Text[0]);

            }
        }
    }


}
