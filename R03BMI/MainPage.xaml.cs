using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A03 大河原　翔太";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String height = heighit.Text;
            String weight = weighit.Text;
            try
            {
                double h = double.Parse(height);
                double w = double.Parse(weight);
                if (h >= 10)
                {
                    h = h / 100;
                }
                if (w >= 1000)
                {
                    w = w / 1000;
                }
                double b = Math.Round(w / ( h * h ) , 1);
                //int b2 = (int)b * 10;
                //double b3 = (double)b2 / 10;
                String s = null;
                if (b < 18.5){
                    s = "低体重（痩せ）";
                }else if (b < 25.0){
                    s = "普通体重";
                }else if (b < 30.0){
                    s = "肥満（1度）";
                }else if (b < 35.0){
                    s = "肥満（2度）";
                }else if (b < 40.0){
                    s = "肥満（3度）";
                }else{
                    s = "肥満（4度）";
                }
                result.Text ="BMI値は"+b+"で"+s+"です。";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "!!!";
            }
        }
    }
}
