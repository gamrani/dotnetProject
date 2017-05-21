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

