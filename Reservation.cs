using System;

namespace project
{
	public class Reservation
	{   
		private Client client ;
		private Chambre Chambre ;
		private DateTime entree ;
		private DateTime sortie ;

		public override string ToString ()
		{
			return string.Format ("[Reservation: client={0}, Chambre={1}, entree={2}, sortie={3}, Client={4}, Entree={5}, Sortie={6}]", client, Chambre, entree, sortie, Client, Entree, Sortie);
		}
		
		public Reservation (Client client, Chambre chambre, DateTime entree, DateTime sortie)
		{
			this.client = client;
			this.Chambre = chambre;
			this.entree = entree;
			this.sortie = sortie;
		}
		public Client Client {
			get {
				return this.client;
			}
			set {
				client = value;
			}
		}

		public DateTime Entree {
			get {
				return this.entree;
			}
			set {
				entree = value;
			}
		}

		public DateTime Sortie {
			get {
				return this.sortie;
			}
			set {
				sortie = value;
			}
		}
	}
}

