using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Repeater1.DataSource = Prodotto.ListaProdotti();
                Repeater1.DataBind();
            }
        }
    }

    public class Prodotto
    {
        public int id { get; set; }
        public string nomeProdotto { get; set; }
        public decimal prezzo { get; set; }
        public string descrizione { get; set; }
        public string img { get; set; }

        public static List<Prodotto> ListaCarrello = new List<Prodotto>();


    public static List<Prodotto> ListaProdotti()
        {
            Prodotto o1 = new Prodotto();
            o1.id = 1;
            o1.nomeProdotto = "Daniel Wellington Petite Bondi";
            o1.prezzo = 134;
            o1.descrizione = "Petite Bondi è caratterizzato da un quadrante bianco guscio d'uovo e dall’elegante cinturino in maglia milanese oro rosa. È il dettaglio perfetto per completare il tuo outfit e migliorare il tuo umore.";
            o1.img = "/img/orologio1.jpg";
            Prodotto o2 = new Prodotto();
            o2.id = 2;
            o2.nomeProdotto = "Daniel Wellington Iconic Link Rose";
            o2.prezzo = 209;
            o2.descrizione = "Con il suo design classico rivisitato in chiave contemporanea, Iconic Link è l’attesa rivelazione frutto di tre anni di design e meticolosa lavorazione artigianale. Iconic Link presenta un bracciale metallico con maglie a tre componenti. Ogni segmento è costituito da elementi di acciaio massiccio realizzati uno ad uno, dalla linea elegantemente affusolata che unisce in maniera armoniosa la cassa al fermaglio.";
            o2.img = "/img/orologio5.jpg";
            Prodotto o3 = new Prodotto();
            o3.id = 3;
            o3.nomeProdotto = "Daniel Wellington Petite Sterling";
            o3.prezzo = 143;
            o3.descrizione = "Petite Sterling è caratterizzato da un quadrante bianco guscio d'uovo e dall’elegante cinturino in maglia milanese oro rosa. È il dettaglio perfetto per completare il tuo outfit e migliorare il tuo umore.";
            o3.img = "/img/orologio3.jpg";
            Prodotto o4 = new Prodotto();
            o4.id = 4;
            o4.nomeProdotto = "Daniel Wellington Classic Bedford";
            o4.prezzo = 159;
            o4.descrizione = "Con caratteristiche classiche come la cassa sottile, i dettagli in oro rosa o argento e il nostro storico cinturino NATO in blu notte, Classic Bayswater è un segnatempo semplice da indossare dal giorno alla sera.";
            o4.img = "/img/orologio6.jpg";
            Prodotto o5 = new Prodotto();
            o5.id = 5;
            o5.nomeProdotto = "Daniel Wellington Quadro Ashfield";
            o5.prezzo = 139;
            o5.descrizione = "Il Quadro è il nostro primo segnatempo con quadrante quadrato. Realizzato in acciaio inossidabile lucido e disponibile in una raffinata placcatura in oro rosa o in una vivace finitura argento. Scegli tra l'opzione di un quadrante fantasia bianco, nero o verde e una selezione di cinturini in rete pressata o pelle pressata. Migliora il tuo look con un tocco unico.";
            o5.img = "/img/orologio4.jpg";
            Prodotto o6 = new Prodotto();
            o6.id = 6;
            o6.nomeProdotto = "Daniel Wellington Petite Melrose";
            o6.prezzo = 129;
            o6.descrizione = "Petite Melrose è caratterizzato da un quadrante bianco guscio d'uovo e dall’elegante cinturino in maglia milanese oro rosa. È il dettaglio perfetto per completare il tuo outfit e migliorare il tuo umore.";
            o6.img = "/img/orologio2.jpg";
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