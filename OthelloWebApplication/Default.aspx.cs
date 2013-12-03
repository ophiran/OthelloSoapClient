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
            playerProfile player = proxy.infoPlayer("toto");
            List<ListItem> items = new List<ListItem>();
            foreach (string item in player.gameList)
            {
                ListItem lItem = new ListItem(item.Replace("&nbsp;", " "));
                items.Add(lItem);
            }
            ListBoxGames.Items.AddRange(items.ToArray());
            Label2.Text = player.gameList[0];
            System.Diagnostics.Debug.WriteLine(player.gameList[0]);
            Console.Out.WriteLine("toto");
            Console.Out.WriteLine(player.gameList[0]);
        }


    }
}