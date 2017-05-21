using System;

namespace project
{
	public class Personnel : Personne
	{
		private string matricule; 
		private string fonction ;
		public Personnel ()
		{
			this.nom = "";
			this.prenom = "";
			this.adresse = "";
			this.matricule = "";
			this.fonction = "";
		}
		public override string ToString ()
		{
			return string.Format ("[Personnel: matricule={0}, fonction={1}, Matricule={2}, Fonction={3}]", matricule, fonction, Matricule, Fonction);
		}
		
		public Personnel(string nom,string prenom,string adresse,string matricule,string fonction)
		{
			this.nom=nom;
			this.prenom=prenom;
			this.adresse=adresse;
			this.matricule = matricule;
			this.fonction = fonction;

		}

		public string Matricule {
			get {
				return this.matricule;
			}
			set {
				matricule = value;
			}
		}

		public string Fonction {
			get {
				return this.fonction;
			}
			set {
				fonction = value;
			}
		}

	  


	}
}

