using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConversieAMasurilor
{
    public partial class Form1 : Form
    {

        Dictionary<string, double> rateDeConversie = new Dictionary<string, double>()
    {
        { "CelsiusFahrenheit", 1.8 },
        { "CelsiusKelvin", 1 },

        { "FahrenheitCelsius", 0.555 },
        { "FahrenheitKelvin", 0.555 },

        { "KelvinCelsius", 1 },
        { "KelvinFahrenheit", 1.8 },

            {"GrameUncii", 0.035},
            {"GrameKilograme", 0.001 },
            {"GrameLivre", 0.0022 },

            {"KilogrameGrame", 1000 },
            {"KilogrameLivre", 2.205 },
            {"KilogrameUncii", 35.274 },

            {"UnciiGrame", 28.35 },
            {"UnciiLivre", 0.0625 },
            {"UnciiKilograme", 0.0283 },

            {"LivreUncii", 16 },
            {"LivreKilograme", 0.453 },
            {"LivreGrame", 453.592 },

        { "MetriiInch", 39.37 },
        { "MetriiFeet", 3.281 },
        { "MetriiKilometrii", 0.001 },

        { "InchMetrii", 0.0254 },
        { "InchFeet", 0.0833 },
        { "InchKilometrii", 0.0000254 },

        { "FeetMetrii", 0.305 },
        { "FeetInch", 12 },
        { "FeetKilometrii", 0.0003048 },

        { "KilometriiMetrii", 1000 },
        { "KilometriiInch", 39370.1 },
        { "KilometriiFeet", 3280.84 }

    };
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Sigur doriti sa iesiti?", "Exit", MessageBoxButtons.YesNo);
            if (Exit == System.Windows.Forms.DialogResult.Yes)
            {
                Application .Exit();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void greutateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Greutate";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] {"Kilograme","Grame","Uncii","Livre"});

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "Kilograme", "Grame", "Uncii", "Livre" });
        }

        private void lungimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Lungime";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Metrii", "Inch", "Feet", "Kilometrii" });

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "Metrii", "Inch", "Feet", "Kilometrii" });
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void temperaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "Temperatura";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin"});


            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string unitatiAlese = comboBox1.Text + comboBox2.Text;
            try
            {
                double rataDeConversie = rateDeConversie[unitatiAlese];
                double rezultat = (Convert.ToDouble(numericUpDown1.Value) * rataDeConversie) + ((comboBox2.Text == "Fahrenheit") ? 32 : 0 + ((comboBox2.Text == "Kelvin") ? -273.15 : 0));
                label1.Text = rezultat.ToString();
            }
            catch
            {
                MessageBox.Show("Alegeti unitati de masura. Acestea trebuie sa fie diferite una fata de cealalta", "Eroare", MessageBoxButtons.OK);
            }
        }
    }
}
