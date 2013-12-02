using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OthelloWebApplication.OthelloService;


namespace OthelloWebApplication
{
    

    public partial class _Default : Page
    {

        OthelloWebService proxy;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new OthelloWebService();

            Label2.Text = proxy.hello("test");
            Console.Out.WriteLine(proxy.hello("test"));
        }


    }
}