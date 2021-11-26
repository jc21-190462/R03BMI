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
            string height = heighit.Placeholder;
            string weight = weighit.Placeholder;
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
                double b = w / (h * h);
                int b2 = (int)b * 10;
                double b3 = (double)b2 / 10;
                string s = null;
                if (3b > 18.5)
                {
                    s = "低体重（痩せ）";
                }else{
                if (b3 > 25.0)
                {
                    s = "普通体重";
                }else{
                if (3b > 30.0)
                {
                    s = "肥満（1度）";
                }else{
                if (b3 > 35.0)
                {
                    s = "肥満（2度）";
                }else{
                if (b3 > 40.0)
                {
                    s = "肥満（3度）";
                }else{
                if (b3 >= 40.0)
                {
                    s = "肥満（4度）";
                }}}}}}
　　　　　　　　Console.WriteLine(Math.Round(b, 1, MidpointRounding.AwayFromZero));
                result.Text =b3 + s;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "!!!";
            }
        }
    }
}
