using System;
using System.Text.RegularExpressions;

namespace Minu_kalkulaator
{
    public class StringManipulation
    {
        // Regular expressionite jaoks kasutatud veebisait https://regexlib.com/CheatSheet.aspx
        public string CalculatorRegex = @"[-\d\b,]";
        public string ControlRegex = @"[\cA\cC\cV\cX]";

        public bool CheckCalculatorInput(string str, int type)
        {
            /* Kui tüübiks on 0, siis kontrollib ta koma TextBoxi KeyPressi sündmusele vastavalt
             * Kontrollib kas kalkulaatori sisend on sobiv
             * Kui tüübiks on 1, siis nii nagu TextBoxi TextChange sündmusel on vaja
             * Kontrollib kas ebasobilikke karaktereid on sisse kleebitud
             * 
             * Ei kasuta SWITCHi siin, kuna teeks koodi ebavajalikult pikaks, on ainult 2 case */


            string regex = type == 1 ? CalculatorRegex.Insert(1, "^") :
                CalculatorRegex.Replace("]", "") + ControlRegex.Replace("[", "");

            return Regex.IsMatch(str, regex);
        }

        public bool CheckControlKey(string str)
        {
            return Regex.IsMatch(str, ControlRegex);
        }

        public bool CheckComma(string str, int type)
        {
            /* Kui tüübiks on 0, siis kontrollib ta koma TextBoxi KeyPressi sündmusele vastavalt
             * True, kui koma pole kuid number on
             * Kui tüübiks on 1, siis nii nagu TextBoxi TextChange sündmusel on vaja
             * Kontrollib kas komasi on üleliia
             * 
             * Ei kasuta SWITCHi siin, kuna teeks koodi ebavajalikult pikaks, on ainult 2 case */

            // et firstIndex == 0, saaks tõene olla, ka negatiivse arvu puhul
            str = str.TrimStart('-'); 
            int firstIndex = str.IndexOf(',');

            if (type == 0) { return Regex.IsMatch(str, @"\d") && firstIndex == -1; }
            else { return firstIndex == 0 || firstIndex != str.LastIndexOf(','); }
        }

        public string RemoveExtraCommas(string str)
        {
            int index = str.IndexOf(',');

            if (index == -1) { return str; }

            // Eemaldab üleliigsed komad
            str = str.Substring(0, index + 1) +
                str.Substring(index).Replace(",", "");
            // Lisab nulli koma ette, kui numbrit ees seal pole
            int beforeComma = index - 1;
            if (beforeComma < 0) str = '0' + str;
            else if (str[beforeComma] == '-') 
                str = str.Insert(beforeComma + 1, "0");

            return str;
        }

        public string ErrorMsg_WrongVar(string[] variables,
            Tuple<string, string>[] grammar,
            int variableInsertionIndex = 1, string startMsg = "")
        {
            /* Genereerib õige veateate valides kas ainsuse või mitmuse vormi
             * grammari elementi Item1 peab olema ainsus, Item2 mitmus     */

            var singular = variables.Length == 1;
            var iteration = grammar.GetEnumerator();

            for (int i = 0; i < grammar.Length; i++)
            {
                if (i == variableInsertionIndex)
                    startMsg += '"' + String.Join("\", \"", variables) + "\" ";
                iterator();

                startMsg += " ";
            }

            void iterator()
            {
                iteration.MoveNext();

                var current = iteration.Current as Tuple<string, string>;
                startMsg += singular ? current.Item1 : current.Item2;
            }

            return startMsg;
        }
    }
}
