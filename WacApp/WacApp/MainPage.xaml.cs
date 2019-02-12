using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WacApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage ()
        {
            InitializeComponent();

            List<string> farmIds = new List<string>
            {
                "DEC-001",
                "DEC-002",
                "DEC-003",
                "DEC-004",
                "DEC-005"
            };

            List<string> landowners = new List<string>
            {
                "Billy Test",
                "Josh Scofield",
                "Reginald Winklebottom III",
                "Jesse Pinkman",
                "Walter White"
            };
        }

        private void FarmInfoTab_Focused(object sender, FocusEventArgs e)
        {            
            FarmSearchPage page = new FarmSearchPage();
        }
    }
}