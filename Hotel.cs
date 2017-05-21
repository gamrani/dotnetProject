using System;

using System.Collections.Generic;
namespace project
{
	public class Hotel
	{
		private string nom ;
		private string adresse;
		private string ville ;
		private List<Personnel> personnels ;
		private Personnel derigeant ;
		private List<Chambre> chambres ;
		private List<Client> clients ;



		public void ajouterClient(Client c){
			clients.Add (c);
		}
		public void ajouterPersonnel(Personnel p){
			personnels.Add (p);
		}

		public List<Client> listClients (){
			return clients;
		}
		public List<Personnel> listPersonnels (){
			return personnels;
		}


		public Hotel ()
		{
			nom = "";
			adresse = "";
			ville = "";
			personnels=new List<Personnel>();
			derigeant = null;
		}
		public Hotel (string nom,String adresse,string ville)
		{
			nom = "";
			adresse = "";
			ville = "";

		}
		public List<Chambre> Chambres {
			get {
				return this.chambres;
			}
			set {
				chambres = value;
			}
		}
		public string Nom {
			get {
				return this.nom;
			}
			set {
				nom = value;
			}
		}

		public string Adresse {
			get {
				return this.adresse;
			}
			set {
				adresse = value;
			}
		}

		public string Ville {
			get {
				return this.ville;
			}
			set {
				ville = value;
			}
		}

		public override string ToString ()
		{
			return string.Format ("[Hotel: nom={0}, adresse={1}, ville={2}, personnels={3}, derigeant={4}, chambres={5}, Chambres={6}, Nom={7}, Adresse={8}, Ville={9}, Personnels={10}, Derigeant={11}]", nom, adresse, ville, personnels, derigeant, chambres, Chambres, Nom, Adresse, Ville, Personnels, Derigeant);
		}
		
		public List<Personnel> Personnels {
			get {
				return this.personnels;
			}
			set {
				personnels = value;
			}
		}

		public Personnel Derigeant {
			get {
				return this.derigeant;
			}
			set {
				derigeant = value;
			}
		}

	}
}

