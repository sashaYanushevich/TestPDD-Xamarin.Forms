using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace labsWPF
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Results : ContentPage
    {
        public Results()
        {
            InitializeComponent();

            Label[] answers = new[] { ans1, ans2, ans3, ans4, ans5, ans6, ans7, ans8, ans9, ans10 };
            Label[] rightAns = new[] {rightAns1, rightAns2, rightAns3, rightAns4, rightAns5, rightAns6, rightAns7, rightAns8, rightAns9, rightAns10 };
            Label[] resulst = new[] {res1, res2, res3, res4, res5, res6, res7, res8, res9, res10 }; 
        }
    }
}