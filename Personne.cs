using System;

namespace project
{
	public abstract class Personne
	{
		
		protected string nom ;
		protected string prenom;
		protected string adresse;

		public override string ToString ()
		{
			return string.Format ("[Personne: nom={0}, prenom={1}, adresse={2}, Nom={3}, Prenom={4}, Adresse={5}]", nom, prenom, adresse, Nom, Prenom, Adresse);
		}
		
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

