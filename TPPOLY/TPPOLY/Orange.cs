using System;
using System.Collections.Generic;
using System.Text;

namespace TPPOLY.LesClasses
{
    class Orange :Fruits // pommes herite Fruits
    {
        public Orange(int p) // le p est egal au poids de la pomme
        {
            this.poids = p; // poids est declare protected dans la cklasse Fruit
            Console.WriteLine("creation d'une orange de " + poids + " grammes " );

        }
        public override void Affiche() // la methode affiche est declare virtual dans Fruit
        {
            //par defaut il appelle la methode de la classe parent : base.Affiche(); 
            Console.WriteLine ("c'est une orange");
        }
        public override  void AffichePoid()
        {
            Console.WriteLine("le poids d'une orange est : " + poids);
        }
    }
}
