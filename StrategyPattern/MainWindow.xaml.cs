using System;
using System.Collections.Generic;
using System.Windows;

namespace StrategyPattern
{
    /**
      * 模式：策略模式
      * 时间：2021-06-23
      * blog：https://www.cnblogs.com/chonglu/
      */
    public partial class MainWindow : Window
    {
        private double total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> CaclcList = new List<string>()
            {
                "正常收费",
                "打8折",
                "满300返100"
            };
            CbCaclc.ItemsSource = CaclcList;
            CbCaclc.SelectedIndex = 0;
        }

        private void GoodsAddBtn_Click(object sender, RoutedEventArgs e)
        {
            CashContext context = new CashContext(CbCaclc.SelectedItem.ToString());
            var totalPrice = context.GetResult(Convert.ToDouble(TextGoodsPrice.Text) * Convert.ToDouble(TextGoodsNum.Text));
            total += totalPrice;
            lBGoodsTodo.Items.Add($"名称：{TextGoodsName.Text}--数量：{TextGoodsNum.Text}--合计：{totalPrice}");
            TextTotal.Text = total.ToString();
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            TextGoodsName.Text = "";
            TextGoodsPrice.Text = "";
            TextGoodsNum.Text = "";
            CbCaclc.SelectedIndex = 0;
            lBGoodsTodo.Items.Clear();
            TextTotal.Text = "0";
        }
    }
}
