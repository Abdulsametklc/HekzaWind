namespace Hekzawind_Prototip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPole_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuten_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Kullanýcýdan gelen girdileri al
            if (!int.TryParse(txtNuten.Text, out int Nuten) || !int.TryParse(txtPole.Text, out int Pole))
            {
                lblResult.Text = "Lütfen geçerli bir sayý girin!";
                return;
            }

            // Geçerlilik Kontrolleri
            if (Nuten % 3 != 0 || Nuten < 3)
            {
                lblResult.Text = "Nutanzahl muss durch 3 teilbar sein! (Nuten 3'ün katý olmalý)";
                return;
            }

            if (Pole % 2 != 0 || Pole < 2)
            {
                lblResult.Text = "Polanzahl muss gerade sein! (Pole çift sayý olmalý)";
                return;
            }

            if (Pole == Nuten)
            {
                lblResult.Text = "Polanzahl muss ungleich Nutanzahl sein! (Pole, Nuten ile eþit olmamalý)";
                return;
            }

            // Hesaplama Ýþlemi
            double Winkel = 180.0 * Pole / Nuten;
            int a = 0, b = 0, c = 0, A = 0, B = 0, C = 0;
            string schema = "";
            double summe = 0;

            for (int i = 0; i < Nuten; i++)
            {
                if (summe >= 330 || summe < 30) { schema += "A"; A++; }
                else if (summe >= 30 && summe < 90) { schema += "b"; b++; }
                else if (summe >= 90 && summe < 150) { schema += "C"; C++; }
                else if (summe >= 150 && summe < 210) { schema += "a"; a++; }
                else if (summe >= 210 && summe < 270) { schema += "B"; B++; }
                else if (summe >= 270 && summe < 330) { schema += "c"; c++; }

                summe = (summe + Winkel) % 360;
            }

            if (a == b && a == c && A == B && A == C)
            {
                while (schema.EndsWith("a") || schema.EndsWith("A"))
                {
                    schema = schema[^1] + schema[..^1];
                    WindingForm windingForm = new WindingForm(schema);
                    windingForm.Show();
                }

                if (schema.StartsWith("a"))
                {
                    schema = schema.Replace('a', 'x').Replace('b', 'y').Replace('c', 'z')
                                   .Replace('A', 'a').Replace('B', 'b').Replace('C', 'c')
                                   .Replace('x', 'A').Replace('y', 'B').Replace('z', 'C');
                }

                if (schema.IndexOfAny(new char[] { 'b', 'B' }) > schema.IndexOfAny(new char[] { 'c', 'C' }))
                {
                    schema = schema.Replace('b', 'x').Replace('c', 'y').Replace('x', 'c').Replace('y', 'b')
                                   .Replace('B', 'x').Replace('C', 'y').Replace('x', 'C').Replace('y', 'B');
                }

                lblResult.Text = "Þema: " + schema;
            }
            else
            {
                lblResult.Text = "Lösung unausgewogen! (" + schema + ")";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
