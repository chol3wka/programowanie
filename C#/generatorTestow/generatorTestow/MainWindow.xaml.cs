using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Collections.Generic;
using System.IO;

namespace generatorTestow
{
    
    public partial class MainWindow : Window
    {
        private const string NazwaPliku = "pytania.txt";
        private List<pytanie> Pytania = new();
        public MainWindow()
        {
            InitializeComponent();
            Pytania = LadujPytania();
            OdswiezPytania();
        }
    }

    public class pytanie
    {
        public string Kategoria { get; set; }
        public string zawartosc { get; set; }
        public string odpA { get; set; }
        public string odpB { get; set; }
        public string odpC { get; set; }
        public string odpD { get; set; }
        public string poprawnaOdpowiedz { get; set; }
        public override string ToString()
        {
            return $"{Kategoria} - {zawartosc}";
        }

    }
    private List<pytanie> LadujPytania()
        {
            List<pytanie> result = new();

            if (!File.Exists(FileName))
            {
                return result;
            }
            foreach (string line in File.ReadAllLines(FileName))
            {
                string[] data = line.Split('|');

                if (data.Length != 7)
                    continue;
                result.Add(new pytanie
                {
                    Kategoria = data[0],
                    zawartosc = data[1],
                    odpA = data[2],
                    odpB = data[3],
                    odpC = data[4],
                    odpD = data[5],
                    poprawnaOdpowiedz = data[6]
                });
            }
            return result;
        }
        private void ZapiszPytanie()
        {
            List<string> lines = new();
            foreach (var q in Pytania)
            {
                lines.Add($"{q.Kategoria}|{q.zawartosc}|{q.odpA}|{q.odpB}|{q.odpC}|{q.odpD}|{q.poprawnaOdpowiedz}");

            }
            File.WriteAllLines(FileName, lines);
        }
        private void OdswiezPytania()
        {
            lstPytania.ItemsSource = null;
            lstPytania.ItemsSource = Pytania;
        
        }
        private void btnDodaj_pytanie(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtkategoria.Text) || string.IsNullOrWhiteSpace(txtpytanie.text))
            {
                MessageBox.Show("Uzupełnij dane!");
                return;
            }
            pytanie q = new pytanie
            {
                Kategoria = txtkategoria.Text;
                zawartosc = txtPytanie.Text;
                odpA = txtA;
                odpB = txtB;
                odpC = txtC;
                odpD = txtD;
                poprawnaOdpowiedz = ((ComboBoxItem)cmbPoprawna.SelectedItem).Content.ToString() 
            };
            pytania.Add(q);

            ZapiszPytanie();
            OdswiezPytania();
            txt.Pytanie.clear();
            txtA.Clear;
            txtB.Clear;
            txtC.Clear;
            txtD.Clear;

            MessageBox.Show("Pytanie zapisane.");
        }
        private void btnGeneruj_test(object sender, RoutedEventArgs e)
        {
            string kategoria = txtTestKategoria.Text;
            if () ;
        }

    }
}