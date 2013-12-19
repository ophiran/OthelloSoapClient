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
            proxy = new OthelloWebServiceClient();
            string query = this.Request.Url.Query;
            
            //infoPlayer test = new infoPlayer();
            infoPlayerResponse resp;
            
            resp = proxy.infoPlayer(new infoPlayerRequest("toto"));
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