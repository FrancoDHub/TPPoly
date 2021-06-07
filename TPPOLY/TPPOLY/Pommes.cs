using System;
using System.Collections.Generic;
using System.Text;

namespace TPPOLY.LesClasses
{
    class Pommes :Fruits // pommes herite Fruits
    {
        public Pommes(int p) // le p est egal au poids de la pomme
                            // :base() appel du constructeur de la classe parent quand il n'y a pas de parametres dans la classe parent cela se fait automatiquement ou implicitement ou par defaut
                      // public Pommes(int p): base(int f) qd il y a un constructeur avec parametre dans la classe parent
        {
            this.poids = p; // poids est declare protected dans la cklasse Fruit
            Console.WriteLine("creation d'une pomme de " + poids + " grammes " );

        }
        public override void Affiche() // la methode affiche est declare virtual dans Fruit
        {
            //par defaut il appelle la methode de la classe parent : base.Affiche(); 
            Console.WriteLine ("c'est une pomme");
        }
        public override void AffichePoid()
        {
            Console.WriteLine("le poids d'une pomme est : " + poids);
        }
    }
}
