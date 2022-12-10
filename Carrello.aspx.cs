using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            decimal totale = 0;
           foreach(Prodotto x in Prodotto.ListaCarrello)
            {
                totale += x.prezzo;
                Label2.Text += $"{x.nomeProdotto} al prezzo di: {x.prezzo.ToString("c2")} ";
                Label3.Text = totale.ToString("c2");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Prodotto.ListaCarrello.Clear();
            Label2.Text = "Il carrello è stato svuotato.";
            Label3.Text = 0.ToString("c2");
        }
    }
}