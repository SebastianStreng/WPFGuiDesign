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

namespace WpfTestApp
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

        private void ShowComboBox(ComboBox combobox, Label label)
        {
            combobox.Visibility = Visibility.Collapsed;
            label.Visibility = Visibility.Collapsed;
        }

        private void ShowTextBox(TextBox textBox, Label label)
        {
            textBox.Visibility = Visibility.Collapsed;
            label.Visibility = Visibility.Collapsed;
        }

        private void BlockAccessInTextBoxIfCheckboxIsFalse(CheckBox checkbox, TextBox textbox)
        {
            if (checkbox.IsChecked == false)
            {
                textbox.IsReadOnly = true;
            }
        }

        private void BlockAccessInComboBoxIfCheckboxIsFalse(CheckBox checkbox, ComboBox comboBox)
        {
            if (checkbox.IsChecked == false)
            {
                comboBox.IsManipulationEnabled = false; //Or "isEnabled"
            }
        }

        private bool CheckIfTextBoxIsNotEmpty(TextBox textbox)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                return true;
            }
            return false;
        }
    }
}