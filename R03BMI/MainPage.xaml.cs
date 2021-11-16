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
                double b = w / h / h;
                if (h >= 10)
                {
                    h = h / 100;
                }
                if (w >= 10)
                {
                    w = w / 100;
                }
                result.Text = "身長" + h + ",体重" + w + "の人のBMIは、" + 
                    b + "です。";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                result.Text = "!!!";
            }
        }
    }
}
