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
using System.Windows.Shapes;

namespace JamFactory.View
{
    /// <summary>
    /// Interaction logic for TilføjVariant.xaml
    /// </summary>
    public partial class TilføjVariant : Window
    {
        Controller.Controller controller;
        public TilføjVariant()
        {
            controller = new Controller.Controller();
            InitializeComponent();
            AddToCombobox();
        }

        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AddToCombobox()
        {
            foreach (string s in controller.GetIngredients())
            {
                IngredientCombo.Items.Add(s);
            }
            IngredientCombo.SelectedIndex = 0;
        }
    }
}
