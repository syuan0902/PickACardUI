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

namespace PickACardUI
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //將CardPick類別宣告成新實例
            CardPicker m_cardPicker = new CardPicker();

            //將Slider的值(Double)轉換成int，才能被PickSomeCards方法使用
            string[] pickedCards = m_cardPicker.PickSomeCards((int)numberOfCards.Value);

            listOfCards.Items.Clear();
            foreach (string card in pickedCards)
            {
                listOfCards.Items.Add(card);
            }
        }
    }
}
