using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace PleszevismsGeneratorWin
{
    [DataContract(Namespace = "http://www.pleszevism.com/pleszevism")]
    public class Pleszevism
    {
        [DataMember]
        private List<string> part1;
        [DataMember]
        private List<string> part2;
        [DataMember]
        private List<string> part3;

        private int maxPleszetonLength
        {
            get
            {
               return Math.Min(part1.Count, Math.Min(part2.Count, part3.Count));
            }
        }
        private Random random;

        public Pleszevism()
        {
            random = new Random();
        }

        public string GenerateSingle()
        {
            return String.Format("{0}{1}{2}", part1[random.Next(part1.Count)], part2[random.Next(part2.Count)], part3[random.Next(part3.Count)]);
        }

        public string GeneratePleszeton (int length, bool unique)
        {
            string felieton = "";

            if (unique)
            {
                felieton = GenerateUniquePleszeton(length);
            }
            else
            {
                felieton = GenerateNonUniquePleszeton(length);
            }

            return felieton;
        }

        private string GenerateNonUniquePleszeton(int length)
        {
            string felieton = "";
            for (int i = 0; i < length; i++)
            {
                felieton += this.GenerateSingle() + " ";
            }

            return felieton;
        }

        private string GenerateUniquePleszeton(int length)
        {
            if (length > maxPleszetonLength)
            {
                return "Za mało pleszewizmów w bazie! Maksymalna długość felietonu bez powtórzeń: " + maxPleszetonLength;
            }

            string felieton = "";

            part1 = Shuffle(part1);
            part2 = Shuffle(part2);
            part3 = Shuffle(part3);

            for (int i = 0; i < length; i++)
            {
                felieton += part1[i] + part2[i] + part3[i] + " ";
            }

            return felieton;
        }

        private List<string> Shuffle(List<string> listToShuffle)
        {
            List<string> shuffledList = new List<string>();
            while(listToShuffle.Count > 0)
            {
                int elementToMove = random.Next(listToShuffle.Count);
                shuffledList.Add(listToShuffle[elementToMove]);
                listToShuffle.RemoveAt(elementToMove);
            }

            return shuffledList;
        }

        [OnDeserializing]
        void OnDeserializing(StreamingContext c)
        {
            random = new Random();
        }
    }
}
