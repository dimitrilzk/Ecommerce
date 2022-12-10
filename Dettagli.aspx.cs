using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idPassato = Request.QueryString["idProdotto"];
            foreach (Prodotto p in Prodotto.ListaProdotti())
            {
                if(p.id == Convert.ToInt32(idPassato))
                {
                    Image1.ImageUrl = p.img.ToString();
                    Label1.Text = p.nomeProdotto;
                    Label2.Text = p.descrizione;
                    Label3.Text = p.prezzo.ToString("c2");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string idPassato = Request.QueryString["idProdotto"];
            foreach (Prodotto p in Prodotto.ListaProdotti())
            {
                if (p.id == Convert.ToInt32(idPassato))
                {
                    Prodotto acquistato = new Prodotto();
                    acquistato.prezzo = p.prezzo;
                    acquistato.nomeProdotto = Label1.Text;
                    acquistato.img = Image1.ImageUrl.ToString();
                    Prodotto.ListaCarrello.Add(acquistato);
                    messaggioAcquisto.Text = "Articolo aggiunto al tuo carrello!";
                }
            }
            //Prodotto acquistato = new Prodotto();
            //acquistato.prezzo = Convert.ToDecimal(Label3.Text);
            //acquistato.nomeProdotto = Label1.Text;
            //acquistato.img = Image1.ImageUrl.ToString();
            //Prodotto.ListaCarrello.Add(acquistato);
            //messaggioAcquisto.Text = "Articolo aggiunto al tuo carrello!";

        }
    }
}