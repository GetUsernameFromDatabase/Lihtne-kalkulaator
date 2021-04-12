using System;
using System.Linq;
using System.Windows.Forms;

namespace Minu_kalkulaator
{
    public partial class Calculator : Form
    {
        readonly Matemaatika Math = new Matemaatika();
        readonly StringManipulation StrMan = new StringManipulation();
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Seostab arvude textboxi nende üleval olevate labelitega
            foreach (TextBox txtBox in Controls.OfType<TextBox>().OrderBy(x => x.Name))
            {
                txtBox.Tag = Controls.OfType<Label>()
                    .Single(x => x.Name == txtBox.Name + "_label");
            }
        }

        private void NotifyUser(string text, string type)
        {
            // Kasutan switchi igaks juhuks kui tahan teisi teavitusi lisada
            switch (type.ToUpper())
            {
                case "ERROR":
                    MessageBox.Show(text, "Viga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }

        private void RelayChosenArithOprToMath()
        {
            // Kõik panelis "Aritmeetilised_Operaatorid" on RadioButtoni tüüpi
            foreach (RadioButton radioButton in Aritmeetilised_Operaatorid.Controls)
            {
                if (radioButton.Checked)
                {
                    Math.UpdateArithmeticalOperator(radioButton.Text);
                    break;
                }
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (InsureInputUsability())
            {
                RelayChosenArithOprToMath();

                var arvudText = this.Controls.OfType<TextBox>()
                    .OrderBy(x => x.Name)  // Järjekord on tähtis
                    .Select(x => x.Text);

                float[] arvudFloat;
                float calculation;
                try
                {
                    arvudFloat = arvudText.Select(ConvertToFloat).ToArray();
                    calculation = Math.Calculate(arvudFloat);
                }
                catch (Exception ex) when (ex is OverflowException || ex is FormatException)
                {
                    return;
                }
                catch (DivideByZeroException)
                {
                    NotifyUser("Nulliga jagamine keelatud", "Error");
                    return;
                }

                var result = String.Join(Math.ArithmeticalOperator.ToString(), arvudText);
                result += '=' + calculation.ToString().Replace('.', ',');

                vastus.Text = result;
            }

            float ConvertToFloat(string txt)
            {
                void OnException(Tuple<string, string>[] grammar)
                {
                    NotifyUser(StrMan.ErrorMsg_WrongVar(GetLabelsToTextBox(txt),
                        grammar), "Error");
                }


                try
                {
                    var output = float.Parse(txt.Replace(',', '.'));
                    return output;
                }
                catch (OverflowException ex)
                {
                    OnException(new Tuple<string, string>[]{
                        Tuple.Create("Kastis", "Kastides"),
                        Tuple.Create("asetseb liiga suur arv",
                        "asetsevad liiga suured arvud") });
                    throw ex;
                }
                catch (FormatException ex)
                {
                    OnException(new Tuple<string, string>[]{
                        Tuple.Create("Kastis", "Kastides"),
                        Tuple.Create("pole sobiv arv",
                        "pole sobivad arvud") });
                    throw ex;
                }
            }
        }
    }
}
