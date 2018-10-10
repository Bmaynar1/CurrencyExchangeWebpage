using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyExchageWebpage
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            ApiHelper.InitializeClient();
            await LoadSource();
        }


        private async Task LoadSource()
        {
            var currncytype = await ExchangeRateProcessor.LoadSource();

            Label1.Text = currncytype.Source;

        }

        protected async void Button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}