using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CurrencyExchageWebpage
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ApiHelper.InitializeClient();
             
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}