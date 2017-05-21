using System;

namespace project
{
	
	enum types  {Individuelle,Double};
	enum categories {Confort , Luxe};
	public class Chambre
	{
		private int numero ;
		private types type ;
		private categories categories ;
		private int prix ; 
		public override string ToString ()
		{
			return string.Format ("[Chambre: numero={0}, type={1}, categories={2}, prix={3}]", numero, type, categories, prix);
		}

		public Chambre (int numero, types type, categories categories, int prix)
		{
			this.numero = numero;
			this.type = types.Double;
			this.categories = categories.Confort;
			this.prix = prix;
		}
		
		public Chambre ()
		{
			this.numero = 0;
			this.type=types.Individuelle;
			this.categories=categories.Confort;
			this.prix = 0;
		}
		public void setPrix(int prix)
		{
			this.prix = prix;
		} 
		public int getPrix(){
			return prix;
		}


		public void setCategories (string a)
		{
			if (a == "Confort") {
				this.categories = categories.Confort;
			}
			if (a == "Luxe") {
				this.categories = categories.Luxe;
			}
		}



	}
}

