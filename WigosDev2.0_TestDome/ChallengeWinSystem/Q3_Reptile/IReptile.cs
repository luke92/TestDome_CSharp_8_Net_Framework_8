using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
     * La especie firedragon implementa la interfaz IReptile
        Cuando eclosiona un huevo de reptil, se creará un nuevo reptil de la misma especie que puso el huevo.
        Se lanza una System.InvalidOperationException si un ReptileEgg intenta eclosionar más de una vez

    TEST CASES
    FireDragon is IReptile
    Fire dragons make other fire dragons
    Other species eggs don't make fire dragons: System.NotImplementedExcepcion at ReptileEgg.ctor -> Line 19
    ReptileEggs can't hatch twice

     */
    public interface IReptile
    {
        ReptileEgg Lay();
    }

    public class FireDragon
    {
        public FireDragon()
        {
        }
    }

    public class ReptileEgg
    {
        public ReptileEgg(Func<IReptile> createReptile)
        {
            throw new NotImplementedException("Waiting to be implemented.");
        }

        public IReptile Hatch()
        {
            throw new NotImplementedException("Waiting to be implemented.");
        }
    }

}
