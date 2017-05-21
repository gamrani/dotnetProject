using System;

namespace project
{
	class MainClass
	{
		enum types  {Individuelle,Double};
		enum categories {Confort , Luxe};
		public static void Main (string[] args)
		{
			Hotel hotel = new Hotel ("CR7","30 rue hadada","casablanca");
			Personnel p1 = new Personnel ("a","b","c","d","e");
			Personnel p2 = new Personnel ("aa","ab","ac","ad","ae");
			Personnel p3 = new Personnel ("ba","bb","bc","bd","be");
			Personnel d = new Personnel ("dba","dbb","dbc","dbd","bde");

			Client c1 = new Client ("c","cc","ccc","cddc");
			Client c2 = new Client ("qdqc","cdqdc","cdqsdqcc","cddcdddd");
			Client c3 = new Client ("cqsdq","ccazea","cazacc","cdaezadc");

			Reservation r = new Reservation (c1,new Chambre(10,types.Double,categories.Luxe,100),new DateTime(2017,5,1),new DateTime(2017,5,9));

		

			hotel.ajouterPersonnel (p1);
			hotel.ajouterPersonnel(p2);
			hotel.ajouterPersonnel (p3);

			hotel.Derigeant = d;

			hotel.ajouterClient (c1);
			hotel.ajouterClient (c2);
			hotel.ajouterClient (c3);






		}
	}
}
