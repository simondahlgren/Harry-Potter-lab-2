using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_2a
{
    class Slytherin : House
    {
      

        public Slytherin()

        {
            HouseGhost = "Den blodiga baronen.";
            Mascot = "Ormen";
            Password = "12345678";

        }

        public override bool AmountOfLetters(string password)

        {
           


            if (password.Length >= 8)
            {

                return true;

            }
            else
            {
                return false;

            }
           

        }

        public override bool HasTheRightVowelsAndConsonants(string password)

        {
            bool isvowelorconsonant = false;

            
            string consonants = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            char b = password[0];
            char e = password.Last();


            foreach (char c in consonants)
            {
                if (c == b)

                {
                    isvowelorconsonant = true;
                    break;

                }

                else
                {
                    isvowelorconsonant = false;
                }

            }

            if (isvowelorconsonant)

            {

                foreach (char c in consonants)
                {
                    if (c == e)

                    {
                        isvowelorconsonant = true;
                        break;

                    }

                    else

                        isvowelorconsonant = false;


                }


            }

            return isvowelorconsonant;

        }

    }
}
