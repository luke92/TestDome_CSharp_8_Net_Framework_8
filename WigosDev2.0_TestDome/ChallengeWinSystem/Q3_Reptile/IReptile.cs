using System;

namespace ChallengeWinSystem.Q3_Reptile
{
    /*
     * Scientists have discovered a species of fire-breathing dragons. 
     * DNA analysis of the dragon reveals that it is a reptile evolved from a common ancestor of crocodile, hundreds of millons of years ago.
     * Even though they're related, the different reptile species cannot cross-breed.
     * Researchers would like to develop a lifecycle model of this rare species, in order to better study them.
     * Complete the implementation below so that:
     * 
     * -The FireDragon species implements the IReptile interface.
     * When a ReptileEgg hatches, a new reptile will be created of the same species that laid the egg.
     * A System.InvalidOperationException is thrown if a ReptileEgg tries to hatch more than once.
     * 
     * Los científicos han descubierto una especie de dragones que escupen fuego.
     * El análisis de ADN del dragón revela que es un reptil que evolucionó a partir de un ancestro común del cocodrilo, hace cientos de millones de años.
     * Aunque estén relacionados, las diferentes especies de reptiles no pueden cruzarse.
     * A los investigadores les gustaría desarrollar un modelo de ciclo de vida de esta rara especie, para estudiarlos mejor.
     * Complete la implementación a continuación para que:
     * 
     * La especie firedragon implementa la interfaz IReptile
        Cuando eclosiona un huevo de reptil, se creará un nuevo reptil de la misma especie que puso el huevo.
        Se lanza una System.InvalidOperationException si un ReptileEgg intenta eclosionar más de una vez

    TEST CASES
    FireDragon is IReptile
    Fire dragons make other fire dragons -> Los dragones de fuego crean otros dragones de fuego.
    Other species eggs don't make fire dragons: System.NotImplementedException at ReptileEgg.ctor (Constructor in ReptileEgg)
    ReptileEggs can't hatch twice -> No puede eclosionar dos veces

     */
    public interface IReptile
    {
        /// <summary>
        /// Poner huevo
        /// </summary>
        /// <returns></returns>
        ReptileEgg Lay();
    }

    public class FireDragon : IReptile
    {
        public FireDragon() { }

        public ReptileEgg Lay()
        {
            return new ReptileEgg(() => new FireDragon());
        }
    }

    public class Alligator : IReptile
    {
        public Alligator() { }

        public ReptileEgg Lay()
        {
            //Esto tiene que crear una excepcion porque solo los FireDragon pueden crear FireDragon
            return new ReptileEgg(() => new FireDragon());
        }
    }

    public class ReptileEgg
    {
        private bool IsHatched;
        private readonly IReptile _reptile;

        public ReptileEgg(Func<IReptile> createReptile)
        {
            //Le sacamos la parte del constructor a la clase padre que llama al constructor
            var targetFullName = createReptile.Target.ToString().Replace("+<>c", "");
            //Obtenemos el nombre completo de la clase de FireDragon
            var typeFireDragonFullName = typeof(FireDragon).FullName;
            
            //Verificamos si el metodo delegado construye un FireDragon y si la clase padre es FireDragon
            if (_reptile is FireDragon && !targetFullName.Equals(typeFireDragonFullName))
            {
                throw new NotImplementedException("Waiting to be implemented.");
            }

            _reptile = createReptile();

        }

        /// <summary>
        /// Eclosionar huevo
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public IReptile Hatch()
        {
            if (IsHatched)
            {
                throw new System.InvalidOperationException("Cannot hatch twice");
            }
            else
            {
                IsHatched = true;
                return _reptile;
            }
        }
    }

}
