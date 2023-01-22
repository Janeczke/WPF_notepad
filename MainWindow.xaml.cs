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

namespace BasicWpfNotepad
{
    /// <summary>
    /// MainWindow.xaml 
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";
        

        public MainWindow()
        {
            InitializeComponent();
        }
   
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "Text|*.txt";


            Nullable<bool> result = dlg.ShowDialog();

         
            if (result == true)
            {
              
                filePath = dlg.FileName;

               
                TextArea.Text = System.IO.File.ReadAllText(filePath);
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.Filter = "Text|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            
            if (result == true)
            {
                
                filePath = dlg.FileName;

                
                System.IO.File.WriteAllText(filePath, TextArea.Text);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextArea.FontFamily = new FontFamily("Arial");
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            TextArea.FontFamily = new FontFamily("Times New Roman");
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            TextArea.FontFamily = new FontFamily("Comic Sans MS");
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            TextArea.FontFamily = new FontFamily("Shruti");
        }

        private void font_Click10(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 10;
        }
        private void font_Click20(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 20;
        }
        private void font_Click30(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 30;
        }
        private void font_Click40(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 40;
        }
        private void font_Click50(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 50;
        }
    }
}
