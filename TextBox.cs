using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Minu_kalkulaator
{
    public partial class Calculator : Form
    {
        // Kasutan seda booleani, et vähendada TextChange üleliigse käivituse mõju
        bool CheckTextBoxTextChange = true;

        private IEnumerable<TextBox> GetTextBoxesByText_Ordered(string text)
        {
            return Controls.OfType<TextBox>()
                        .Where(x => x.Text == text)
                        .OrderBy(x => x.Name);
        }

        private string[] GetLabelsToTextBox(string TextBox_Text)
        {
            return GetTextBoxesByText_Ordered(TextBox_Text)
                .Select(x => (x.Tag as Label).Text).ToArray();
        }

        private bool InsureInputUsability()
        {
            // Kontrollib kas TextBoxid on tühjad
            bool NoProblems = true;

            var emptyTxtBoxes = GetTextBoxesByText_Ordered("")
                .Select(x => (x.Tag as Label).Text).ToArray();

            if (emptyTxtBoxes.Length != 0)
            {
                NoProblems = false;
                var grammar = new Tuple<string, string>[]{
                    Tuple.Create("Kastis", "Kastides"),
                    Tuple.Create("puudub sisend", "puuduvad sisendid")
                };

                NotifyUser(StrMan.ErrorMsg_WrongVar(emptyTxtBoxes, grammar)
                    , "Error");
            }
            return NoProblems;
        }

        private void FilterKeyPress_Textbox(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            string txt = txtBox.Text;

            CheckTextBoxTextChange = false;

            // Ei luba läbi ühtegi karakteri, mis matchib regular expressionit
            if (!StrMan.CheckCalculatorInput(e.KeyChar.ToString(), 0))
            {
                e.Handled = true;
            }
            // Komaga tegelev osa
            else if (e.KeyChar.Equals(','))
            {
                if (!StrMan.CheckComma(txt, 0))
                    e.Handled = true;
            }
            // Miinusega tegelev osa
            else if (e.KeyChar.Equals('-'))
            {
                if (txt.StartsWith("-"))
                    txtBox.Text = txt.Substring(1);
                else
                    txtBox.Text = "-" + txt;

                txtBox.SelectionStart = txtBox.Text.Length;
                e.Handled = true;
            }
            // Kui kasutatakse CTRL + (täht), siis lubab TextChange sündmust käsitleda
            else if (StrMan.CheckControlKey(e.KeyChar.ToString()))
            {
                CheckTextBoxTextChange = true;
            }
        }

        private void ControlPasting_Textbox(object sender, EventArgs e)
        {
            /* Kasutan TextChange sündmust, et kontrollida kopeerimist
             * ilma sisseehitatud koodi muutmist                    */

            // Ebavajalike funktsiooni jooksutuste mõju vähendamiseks
            if (!CheckTextBoxTextChange)
            {
                CheckTextBoxTextChange = true;
                return;
            }

            TextBox txtBox = sender as TextBox;
            string txt = txtBox.Text;

            if (StrMan.CheckCalculatorInput(txt, 1))
            {
                NotifyUser("Tähed ei sobi siia!\n" +
                    "Punktide asemel kasuta komasi", "Error");
                txtBox.Text = "";

                return;
            }
            // Tegeleb miinustega
            if (!(txt.LastIndexOf('-') < 1))
                txt = (txt.IndexOf('-') == 0 ? "-" : "") +
                    txt.Replace("-", "");
            // Tegeleb üleliigsete komadega
            if (StrMan.CheckComma(txt, 1))
                txt = StrMan.RemoveExtraCommas(txt);

            // Vajalik, et muudatus oleks lõpus -
            // Iga muudatuse korral läheb tööle see funktsioon
            CheckTextBoxTextChange = false;
            txtBox.Text = txt;

            txtBox.SelectionStart = txt.Length;
        }
    }
}
