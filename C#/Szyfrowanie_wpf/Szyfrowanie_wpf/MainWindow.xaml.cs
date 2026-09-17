using System.IO;
using System.Windows;

namespace Szyfrowanie_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Szyfruj_click(object sender, RoutedEventArgs e)
        {
            string tekst = InputText.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(tekst))
            {
                CezaraOutput.Text = string.Empty;
                PrzestawieniowyOutput.Text = string.Empty;
                GaderypoluciOutput.Text = string.Empty;
                MessageBox.Show("Najpierw zaszyfruj tekst.", "Brak tekstu", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            char[] znaki = tekst.ToCharArray();

            CezaraOutput.Text = SzyfrCezara(znaki);
            PrzestawieniowyOutput.Text = SzyfrPrzestawieniowy(znaki);
            GaderypoluciOutput.Text = SzyfrGaderypoluci(znaki);
        }

        private void CopyCezar_Click(object sender, RoutedEventArgs e)
        {
            KopiujDoSchowka(CezaraOutput.Text);
        }

        private void CopyPrzestawieniowy_Click(object sender, RoutedEventArgs e)
        {
            KopiujDoSchowka(PrzestawieniowyOutput.Text);
        }

        private void CopyGaderypoluki_Click(object sender, RoutedEventArgs e)
        {
            KopiujDoSchowka(GaderypoluciOutput.Text);
        }

        private void Save_click(object sender, RoutedEventArgs e)
        {
            string sciezkaPliku = Path.Combine(AppContext.BaseDirectory, "szyfry.txt");
            string zawartosc = $"Tekst: {InputText.Text}\n" +
                $"Szyfr Cezara: {CezaraOutput.Text}\n" +
                $"Szyfr Przestawieniowy: {PrzestawieniowyOutput.Text}\n" +
                $"Szyfr GADERYPOLUKI: {GaderypoluciOutput.Text}";
            File.AppendAllText(sciezkaPliku, zawartosc + Environment.NewLine + Environment.NewLine);
            MessageBox.Show("Dane zostały zapisane do pliku szyfry.txt.", "Zapis zakończony", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void KopiujDoSchowka(string tekst)
        {
            if (string.IsNullOrWhiteSpace(tekst))
            {
                MessageBox.Show("Najpierw zaszyfruj tekst.", "Brak szyfru", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Clipboard.SetText(tekst);
            MessageBox.Show("Skopiowano do schowka.", "Kopiowanie zakończone", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private static string SzyfrCezara(char[] arr)
        {
            char[] wynik = (char[])arr.Clone();

            for (int i = 0; i < wynik.Length; i++)
            {
                if (wynik[i] >= 'A' && wynik[i] <= 'Z')
                    wynik[i] = (char)('A' + (wynik[i] - 'A' + 5) % 26);
                else if (wynik[i] >= 'a' && wynik[i] <= 'z')
                    wynik[i] = (char)('a' + (wynik[i] - 'a' + 5) % 26);
            }

            return new string(wynik);
        }

        private static string SzyfrPrzestawieniowy(char[] arr)
        {
            char[] wynik = (char[])arr.Clone();

            for (int i = 0; i + 1 < wynik.Length; i += 2)
            {
                (wynik[i], wynik[i + 1]) = (wynik[i + 1], wynik[i]);
            }

            return new string(wynik);
        }

        private static string SzyfrGaderypoluci(char[] arr)
        {
            const string pierwszy = "GADERYPOLUKI";
            const string drugi = "AGEDYROPULIK";
            char[] wynik = (char[])arr.Clone();

            for (int i = 0; i < wynik.Length; i++)
            {
                bool malaLitera = char.IsLower(wynik[i]);
                char znak = char.ToUpper(wynik[i]);
                int indeks = pierwszy.IndexOf(znak);

                if (indeks >= 0)
                {
                    znak = drugi[indeks];
                }
                else
                {
                    indeks = drugi.IndexOf(znak);
                    if (indeks >= 0)
                    {
                        znak = pierwszy[indeks];
                    }
                }

                wynik[i] = malaLitera ? char.ToLower(znak) : znak;
            }

            return new string(wynik);
        }
    }
}
