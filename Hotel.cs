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

		public Hotel ()
		{
			nom = "";
			adresse = "";
			ville = "";
			personnels=new List<Personnel>();
			derigeant = null;
		}
		public Hotel (string nom,string prenom,string ville,List<Personnel> personnels,Personnel d)
		{
			nom = "";
			adresse = "";
			ville = "";
			this.personnels=personnels;
			derigeant = d;
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

