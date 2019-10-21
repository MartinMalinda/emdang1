using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominoes to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            PlayDominoes(dominoes);
            Console.ReadLine();



        }

        public static List<Domino> InitializeDominoes()
        {
            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));


            foreach (var item in dominoes)
            {
                Console.WriteLine(item.GetValues());
            }
            return dominoes;
        }

        public static void PlayDominoes(List<Domino> listOfDominoes){

            List<Domino> orderedDominoes = new List<Domino>();
            //string[] orderedDominoes = new string[listOfDominoes.Count];

            orderedDominoes.Add(listOfDominoes[0]);         // saving the first domino

            for (int i = 0; i < listOfDominoes.Count; i++)
            {
                int[] domOne = listOfDominoes[i].GetValues();

                for (int j = 1; j < listOfDominoes.Count+1; j++)
                {

                    //orderedDominoes[i] = listOfDominoes[i].GetValues().ToString();

                    int[] domTwo = listOfDominoes[j].GetValues();



                    if (domOne[1] == domTwo[0])
                    {
                        orderedDominoes.Add(listOfDominoes[j]);  // saving the second "right" domino
                        //orderedDominoes[j] = listOfDominoes[j].GetValues().ToString();
                        //listOfDominoes.RemoveAt();
                        
                    }

                }
                
            }

            foreach (var item in listOfDominoes)
            {
                Console.Write(item.GetValues()[0]);
                Console.Write(item.GetValues()[1]);
                Console.WriteLine();

            }




        }
    }
}
