using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeWinSystem.Q4_OrderChars
{
    public class Q4OrderChars
    {
        /*
         * Select all acceptable answers
         * a) OrerChars ("a", "b").ToArray() will return ['b', 'a']
         * b) OrerChars ("ab", "ab").ToArray() will return ['a', 'b']
         * c) OrerChars ("b1", "a0").ToArray() will return ['a', 'b']
         * d) Sorting will be deferred until the results are iterated over to List/ ToArray is called
         * La ordenación se aplazará hasta que los resultados se iteren a List/ToArray se llama
         */
        public static IEnumerable<char> OrderChars(params string[] strings)
        {
            return strings.SelectMany(str => str.ToCharArray())
                .Where(chr => Char.IsLetter(chr)).OrderBy(chr => chr);
        }
    }
}
