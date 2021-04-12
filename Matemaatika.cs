using System;
using System.Collections.Generic;
using System.Linq;

namespace Minu_kalkulaator
{
    public class Matemaatika
    {
        public char ArithmeticalOperator { get; private set; }
        // Kasutan sõnastikku, sest on kompaktsem kui if laused, Vist kiirem ka
        private readonly Dictionary<char, Func<float[], float>> arithmeticalOperators =
            new Dictionary<char, Func<float[], float>> {
                { '+', Add },
                { '-', Subtract },
                { '*', Multiply },
                { '/', Divide } };

        public Matemaatika()
        {
            this.ArithmeticalOperator = '+';
        }

        public void UpdateArithmeticalOperator(string chosenOperator)
        {
            var translation = new Dictionary<string, char> {
                { "Liida", '+'},
                { "Lahuta", '-'},
                { "Korruta", '*'},
                { "Jaga",'/' } };

            this.ArithmeticalOperator = translation[chosenOperator];
        }

        // Sisendiks on float[], juhul kui tahan lisada kolme arvuga kalkuleerimist
        private static float Add(float[] arvud) { return arvud.Sum(); }
        private static float Subtract(float[] arvud)
        {
            var output = arvud[0];
            for (int i = 1; i < arvud.Length; i++)
                output -= arvud[i];

            return output;
        }
        private static float Multiply(float[] arvud)
        {
            var output = arvud[0];

            for (int i = 1; i < arvud.Length; i++)
                output *= arvud[i];

            return output;
        }
        private static float Divide(float[] arvud)
        {
            var output = arvud[0];

            for (int i = 1; i < arvud.Length; i++)
                output /= arvud[i];

            return output;
        }

        public float Calculate(float[] arvud)
        {
            if (ArithmeticalOperator == '/')
            {
                bool nulligaJagamine = new ArraySegment<float>
                    (arvud, 1, arvud.Length-1).Contains(0);
                if (nulligaJagamine)
                    throw new DivideByZeroException();
            }
            return arithmeticalOperators[ArithmeticalOperator](arvud);
        }
    }
}
