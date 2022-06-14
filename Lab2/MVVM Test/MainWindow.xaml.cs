using System;
using System.ComponentModel;
using System.Windows;

namespace MVVM_Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel(new DefaultDialogService(), new JsonFileService());
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            string msg = "Changes not saved. Close without saving?";
            MessageBoxResult result = MessageBox.Show(msg, "Data App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}