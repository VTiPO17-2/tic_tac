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


namespace tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txt1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock txt = (TextBlock)sender;
            txt.IsEnabled = false;
            DragDrop.DoDragDrop(txt, txt.Text, DragDropEffects.Copy);
        }

        private void txtTarget_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
            ((TextBlock)sender).IsEnabled = false;
            
        }

         class Logic
        {
            
        }

    }
}
