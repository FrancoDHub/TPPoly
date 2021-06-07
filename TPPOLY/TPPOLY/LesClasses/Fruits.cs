using System;
using System.Collections.Generic;
using System.Text;

namespace TPPOLY.LesClasses
{
    public abstract class Fruits  // une methode Virtual  est une methode qui peut definir dans les classes derives en utilisant le mot cle override
    {
        protected int poids;
         
        public Fruits()
        // exemple si vous creez un contructeur  dans la classe parent avec des parametres public Fruits(int f) dans les classes derives il faut aussi l'appeler avec : base(int f)
        {
            Console.WriteLine("creation d'1 fruit");

        }
        public virtual void Affiche() // une methode Virtual  est une methode qui peut definir dans les classes derives en utilisant le mot cle override
        {
            Console.WriteLine("c'est un fruit");
        }
        public abstract void AffichePoid();

        

        
    }
}
