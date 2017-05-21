using System;

namespace project
{
	public class Client : Personne
	{
		private string CIN ;
		public Client ()
		{
			this.nom = "";
			this.prenom = "";
			this.adresse = "";
			this.CIN = "";

		}
		public override string ToString ()
		{
			return string.Format ("[Client: CIN={0}]", CIN);
		}
		
		public Client (string nom,string prenom,string adresse ,string cin)
		{
			this.nom = nom;
			this.prenom =prenom;
			this.adresse =adresse;
			this.CIN = cin;

		}

		public void setCin(string cin)
		{
			this.CIN = cin;
		}
		public string getCin()
		{
			return this.CIN;
		}
	  
	}
}

