using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = Prodotto.ListaProdotti();
            Repeater1.DataBind();
        }
    }
    public class Prodotto
    {
        public int id { get; set; }
        public string nomeProdotto { get; set; }
        public decimal prezzo { get; set; }
        public string descrizione { get; set; }
        public string img { get; set; }
        public static List<Prodotto> ListaProdotti()
        {
            Prodotto o1 = new Prodotto();
            o1.id = 1;
            o1.nomeProdotto = "Daniel Wellington 1";
            o1.prezzo = 128;
            o1.descrizione = "Petite with the black dial in rose gold or silver is the perfect match with the alluring leather in the Sheffield strap. A true eye-catcher that never will go unnoticed.";
            o1.img = "/img/orologio1.jpg";
            Prodotto o2 = new Prodotto();
            o2.id = 2;
            o2.nomeProdotto = "Daniel Wellington 2";
            o2.prezzo = 128;
            o2.descrizione = "Petite with the black dial in rose gold or silver is the perfect match with the alluring leather in the Sheffield strap. A true eye-catcher that never will go unnoticed.";
            o2.img = "/img/orologio2.jpg";
            Prodotto o3 = new Prodotto();
            o3.id = 3;
            o3.nomeProdotto = "Daniel Wellington 3";
            o3.prezzo = 128;
            o3.descrizione = "Petite with the black dial in rose gold or silver is the perfect match with the alluring leather in the Sheffield strap. A true eye-catcher that never will go unnoticed.";
            o3.img = "/img/orologio3.jpg";
            Prodotto o4 = new Prodotto();
            o4.id = 4;
            o4.nomeProdotto = "Daniel Wellington 4";
            o4.prezzo = 128;
            o4.descrizione = "Petite with the black dial in rose gold or silver is the perfect match with the alluring leather in the Sheffield strap. A true eye-catcher that never will go unnoticed.";
            o4.img = "/img/orologio4.jpg";
            Prodotto o5 = new Prodotto();
            o5.id = 5;
            o5.nomeProdotto = "Daniel Wellington 5";
            o5.prezzo = 128;
            o5.descrizione = "Petite with the black dial in rose gold or silver is the perfect match with the alluring leather in the Sheffield strap. A true eye-catcher that never will go unnoticed.";
            o5.img = "/img/orologio5.jpg";
            Prodotto o6 = new Prodotto();
            o6.id = 6;
            o6.nomeProdotto = "Daniel Wellington 6";
            o6.prezzo = 128;
            o6.descrizione = "Petite with the black dial in rose gold or silver is the perfect match with the alluring leather in the Sheffield strap. A true eye-catcher that never will go unnoticed.";
            o6.img = "/img/orologio6.jpg";
            List<Prodotto> lista = new List<Prodotto>();
            lista.Add(o1);
            lista.Add(o2);
            lista.Add(o3);
            lista.Add(o4);
            lista.Add(o5);
            lista.Add(o6);
            return lista;
        }

    }
}