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
        playerProfile player;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new OthelloWebService();
            string query = this.Request.Url.Query;
            /*
            foreach(string key in this.Request.Url.Query)
            {
                Console.Out.WriteLine(key);
            }*/

            infoPlayer test = new infoPlayer();
            infoPlayerResponse resp;

            @string name = new OthelloService.@string();
            name.Actor = "toto";
            proxy.username = name;

            
            resp = proxy.infoPlayer(test);
            player = resp.@return;
            
            List<ListItem> items = new List<ListItem>();
            foreach (string item in player.gameList)
            {
                ListItem lItem = new ListItem(item.Replace("&nbsp;", " "));
                items.Add(lItem);
            }
            ListBoxGames.Items.Clear();
            ListBoxGames.Items.AddRange(items.ToArray());

            UserName.Text = "Username: " + player.username;
            wins.Text = "Wins: " + player.wins;
            losses.Text = "Losses: " + player.loss;
        }

        


    }
}