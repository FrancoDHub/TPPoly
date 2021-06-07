using System;
using TPPOLY.LesClasses;
using System.Collections; //POUR LES LISTES
using System.Collections.Generic;


namespace TPPOLY
{
    class Program
    {
        static void Main(string[] args)  //  on ne peut pas creer l'instance d'une classe absttraite mais avec  ses derives Fruits f = new Fruits()
        {
            /************** POLYMORPHISME AVEC INSTANCIATIO*************
             
            //Creation d'une instance pommes ou objet de type pomme
            Pommes p = new Pommes(90);    // qd vous creez l'instanciation d'une classe derive il y a automatiquement instanciation de la classe parent + la classe derive

            //Creation d'une instance Orange ou objet de type Orange
            Orange o = new  Orange(80);    // 

            Console.ReadLine();
          


            // ************** POLYMORPHISME AVEC SUR-CASTING************* exemple je cree un objet de type POMMES et je le considere comme un objet de type FRUITS
            //Le SURCASTING peut se faire implictement ou Explicitement
            Fruits f; //ATTIBUT DE TYPE FRUITS
            f = new Pommes(80); // je lui attribue un objet de type POMMES ce surcastiong est implicite
            f =(Fruits) new Pommes(80); // je lui attribue un objet de type POMMES ce surcastiong est explicite
            //Les deux est la meme chose mais polymorphisme  implicite et Explicite

            Console.ReadLine();

            

            // ************** POLYMORPHISME AVEC SOUS-CASTING************* exemple je cree un objet de type POMMES et je le considere comme un objet de type FRUITS

            //Le SURCASTING peut se faire implictement ou Explicitement
            Fruits f; //ATTIBUT DE TYPE FRUITS
            f = new Pommes(80); // je lui attribue un objet de type POMMES ce surcastiong est implicite
            //Sije veux appeler la methose la methode affichePoids qui est dans pomme, je dois le faire Explicite parce cette methode n'est pas dans Fruis

            ((Pommes)f).AffichePoid();  // Explicite

            f.Affiche(); // Implicite parce que la classe Fruit contient la methode Affiche() mais il va appeler la methode qui est dans pomme parce que,f = new Pommes(80);  DONC: SScasting implicite

        //lE SOUSCASTING DOIT SE FAIRE EXPLICITEMENT SI LA METHODE N'EST PAS DECLARE DANS LA CLASSE PARENT
            Console.ReadLine();
             


            // ************** POLYMORPHISME AVEC les TABLEAUX*************
            //DECLARATION D'1 TABLEAU DE FRUITS INIATLISE 
            Fruits[] lesfruits = new Fruits[3]; // 3 = le nombre de champs du tableau
            lesfruits[0] = new Pommes(90); // un tableau commence toujours a partir de zero
            lesfruits[1] = new Orange(70);
            lesfruits[2] = new Pommes(60);

            // parcourir les elements du tableau
            for (int i = 0; i < lesfruits.Length; i++)
            {
                //appel lamethode Affiche qui se trouve dans la classe parent
                lesfruits[i].Affiche(); // implicite
                // si on veut appeler la methode AffichePoid sans probleme,il faut creer une methode affichepoids abstract  dans la classe parent
                // ce qui va tout changer, parce que la classe va etre aussi Abstract et AffichePoids va etre redefinir Override dans les classes derives
                lesfruits[i].AffichePoid(); // cela nous permet d'utiliser le sous-Casting  implicite

            }
            Console.ReadLine();
             */

            // ************** POLYMORPHISME UTILISATION DES COLLECTIONS OU TABLEAU DYNAMIQUES*************

            List<Fruits> lesfruits = new List<Fruits>();
            lesfruits.Add(new Pommes(90)); // ajoute un objet de type pomme
            lesfruits.Add(new Orange(70));
            lesfruits.Add(new Pommes(80));
            // qd il s'agit des tableaux cêst Lenght et Collections count
            for (int i = 0; i < lesfruits.Count; i++)  // parcourir liste ou tableau
            {
                lesfruits[i].Affiche();
            }
            // ou bien vous utliser foreach
            foreach (Fruits f in lesfruits)   // les 2 possibilites
            {
                f.Affiche();

            }
            Console.ReadLine();
        }
    }
}
