using System;

namespace project
{
	public abstract class Personne
	{
		
		protected string nom ;
		protected string prenom;
		protected string adresse;

		public string Nom {
			get {
				return this.nom;
			}
			set {
				nom = value;
			}
		}

		public string Prenom {
			get {
				return this.prenom;
			}
			set {
				prenom = value;
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

	
	}
}

