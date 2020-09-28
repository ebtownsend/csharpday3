using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp3
{
    class shop
    {
        public void details(int bill, int paid)
        {
            int change = paid - bill;
            Console.WriteLine("Change = £" + change);

            int fiftyNotes, twentyNotes, tenNotes, fiveNotes, twoCoins, oneCoins;
        
            if ( change >= 50 )
            {
                fiftyNotes = change / 50;
                Console.WriteLine("£50 = " + fiftyNotes);
                change -= (50 * fiftyNotes);
            }

            if ( change >= 20 )
            {
                twentyNotes = change / 20;
                Console.WriteLine("£20 = " + twentyNotes);
                change -= (20 * twentyNotes);
            }

            if ( change >= 10 )
            {
                tenNotes = 1;
                Console.WriteLine("£10 = " + tenNotes);
                change -= 10;
            }

            if ( change >= 5 )
            {
                fiveNotes = 1;
                Console.WriteLine("£5 = " + fiveNotes);
                change -= 5;
            }

            if( change >= 2 )
            {
                twoCoins = change / 2;
                Console.WriteLine("£2 = " + twoCoins);
                change -= (2 * twoCoins);
            }

            if ( change >= 1)
            {
                oneCoins = 1;
                Console.WriteLine("£1 = " + oneCoins);
                change -= 1;
            }
        }
    }
}
