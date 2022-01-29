using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeWinSystem.Q4_OrderChars
{
    public class Q4OrderChars
    {
        public static IEnumerable<char> OrderChars(params string[] strings)
        {
            return strings.SelectMany(str => str.ToCharArray())
                .Where(chr => Char.IsLetter(chr)).OrderBy(chr => chr);
        }
    }
}
