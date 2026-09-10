using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.ComponentModel;

namespace Net_Notatnik
{
    public partial class MainWindow : Window
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string sciezkaPliku = null;
        private bool czyTekstZmieniony;

        public MainWindow()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik tekstowy";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt| Wszystkie pliki (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Zapisz plik tekstowy";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = openFileDialog.Filter;
            saveFileDialog.FilterIndex = 1;
        }

        private void MenuItem_Otworz_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sciezkaPliku))
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(sciezkaPliku);
                openFileDialog.FileName = Path.GetFileName(sciezkaPliku);
            }

            bool? wynik = openFileDialog.ShowDialog();

            if (wynik.HasValue && wynik.Value)
            {
                sciezkaPliku = openFileDialog.FileName;
                TextBox.Text = File.ReadAllText(sciezkaPliku);
                statusBarText.Text = Path.GetFileName(sciezkaPliku);
                czyTekstZmieniony = false;
            }
        }

        private void MenuItem_ZapiszJako_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sciezkaPliku))
            {
                saveFileDialog.InitialDirectory = Path.GetDirectoryName(sciezkaPliku);
                saveFileDialog.FileName = Path.GetFileName(sciezkaPliku);
            }

            bool? wynik = saveFileDialog.ShowDialog();

            if (wynik.HasValue && wynik.Value)
            {
                sciezkaPliku = saveFileDialog.FileName;
                File.WriteAllText(sciezkaPliku, TextBox.Text);
                statusBarText.Text = Path.GetFileName(sciezkaPliku);
                czyTekstZmieniony = false;
            }
        }

        private void MenuItem_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sciezkaPliku))
            {
                File.WriteAllText(sciezkaPliku, TextBox.Text);
                czyTekstZmieniony = false;
            }
            else
            {
                MenuItem_ZapiszJako_Click(sender, e);
            }
        }

        private void MenuItem_Zamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_GodzinaData_Click(object sender, RoutedEventArgs e)
        {
            TextBox.SelectedText = System.DateTime.Now.ToString();
        }

        private void Textbox_TextChanged(object sender, RoutedEventArgs e)
        {
            czyTekstZmieniony = true;
        }

        private void MenuItem_Nowy_Click(object sender, RoutedEventArgs e)
        {
            bool anuluj;
            zapytajOZapisanieTekstuDoPliku(sender, out anuluj);

            if (!anuluj)
            {
                TextBox.Clear();
                sciezkaPliku = null;
                statusBarText.Text = "Nowy dokument";
                czyTekstZmieniony = false;
            }
        }

        private void MenuItem_Cofnij_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Undo();
        }

        private void MenuItem_Usun_Click(object sender, RoutedEventArgs e)
        {
            TextBox.SelectedText = "";
        }

        private void MenuItem_Powtorz_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Redo();
        }

        private void MenuItem_Wytnij_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Cut();
        }

        private void MenuItem_Kopiuj_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Copy();
        }

        private void MenuItem_Wklej_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Paste();
        }

        private void MenuItem_ZaznaczWszystko_Click(object sender, RoutedEventArgs e)
        {
            TextBox.SelectAll();
        }

        private void MenuItem_Zawijanie_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            TextBox.TextWrapping = item.IsChecked ? TextWrapping.Wrap : TextWrapping.NoWrap;
        }

        private void MenuItem_PasekNarzedzi_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            toolBarTray.Visibility = item.IsChecked ? Visibility.Visible : Visibility.Collapsed;
        }

        private void MenuItem_PasekStanu_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            statusBar.Visibility = item.IsChecked ? Visibility.Visible : Visibility.Collapsed;
        }

        private void MenuItem_KolorTla_Click(object sender, RoutedEventArgs e)
        {
            Window okno = new Window();
            okno.Title = "Kolor tła";
            okno.Width = 250;
            okno.Height = 150;
            okno.ResizeMode = ResizeMode.NoResize;
            okno.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            okno.Owner = this;

            StackPanel panel = new StackPanel();
            panel.Margin = new Thickness(10);

            ComboBox combo = new ComboBox();
            combo.Items.Add("Biały");
            combo.Items.Add("Żółty");
            combo.Items.Add("Szary");
            combo.Items.Add("Niebieski");
            combo.SelectedIndex = 0;

            Button ok = new Button();
            ok.Content = "OK";
            ok.Margin = new Thickness(0, 10, 0, 0);

            ok.Click += (s, ev) =>
            {
                switch (combo.SelectedItem.ToString())
                {
                    case "Biały": TextBox.Background = Brushes.White; break;
                    case "Żółty": TextBox.Background = Brushes.LightYellow; break;
                    case "Szary": TextBox.Background = Brushes.LightGray; break;
                    case "Niebieski": TextBox.Background = Brushes.LightBlue; break;
                    
                }
                okno.Close();
            };

            panel.Children.Add(combo);
            panel.Children.Add(ok);
            okno.Content = panel;
            okno.ShowDialog();
        }

        private void MenuItem_Czcionka_Click(object sender, RoutedEventArgs e)
        {
            Window okno = new Window();
            okno.Title = "Czcionka";
            okno.Width = 300;
            okno.Height = 200;
            okno.ResizeMode = ResizeMode.NoResize;
            okno.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            okno.Owner = this;

            StackPanel panel = new StackPanel();
            panel.Margin = new Thickness(10);

            ComboBox czcionki = new ComboBox();
            foreach (FontFamily font in Fonts.SystemFontFamilies)
                czcionki.Items.Add(font.Source);

            czcionki.SelectedItem = TextBox.FontFamily.Source;

            ComboBox rozmiar = new ComboBox();
            rozmiar.Items.Add("10");
            rozmiar.Items.Add("12");
            rozmiar.Items.Add("14");
            rozmiar.Items.Add("16");
            rozmiar.Items.Add("18");
            rozmiar.Items.Add("20");
            rozmiar.SelectedItem = TextBox.FontSize.ToString();

            Button ok = new Button();
            ok.Content = "OK";
            ok.Margin = new Thickness(0, 10, 0, 0);

            ok.Click += (s, ev) =>
            {
                TextBox.FontFamily = new FontFamily(czcionki.SelectedItem.ToString());
                TextBox.FontSize = double.Parse(rozmiar.SelectedItem.ToString());
                okno.Close();
            };

            panel.Children.Add(czcionki);
            panel.Children.Add(rozmiar);
            panel.Children.Add(ok);
            okno.Content = panel;
            okno.ShowDialog();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (czyTekstZmieniony)
            {
                MessageBoxResult wynik = MessageBox.Show(
                    "Czy chcesz zapisać zmiany przed zamknięciem?",
                    "Zamknij",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Question,
                    MessageBoxResult.Cancel);

                switch (wynik)
                {
                    case MessageBoxResult.Yes:
                        MenuItem_Zapisz_Click(sender, null);
                        break;
                    case MessageBoxResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void zapytajOZapisanieTekstuDoPliku(object sender, out bool anuluj)
        {
            anuluj = false;

            if (czyTekstZmieniony)
            {
                MessageBoxResult wynik = MessageBox.Show(
                    "Czy chcesz zapisać zmiany przed kontynuacją?",
                    "Zapisz zmiany",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Question,
                    MessageBoxResult.Cancel);

                switch (wynik)
                {
                    case MessageBoxResult.Yes:
                        MenuItem_Zapisz_Click(sender, null);
                        break;
                    case MessageBoxResult.Cancel:
                        anuluj = true;
                        break;
                }
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
                MenuItem_GodzinaData_Click(sender, null);

            if ((Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                switch (e.Key)
                {
                    case Key.N: MenuItem_Nowy_Click(sender, null); e.Handled = true; break;
                    case Key.O: MenuItem_Otworz_Click(sender, null); e.Handled = true; break;
                    case Key.S: MenuItem_Zapisz_Click(sender, null); e.Handled = true; break;
                    case Key.Z: MenuItem_Cofnij_Click(sender, null); e.Handled = true; break;
                    case Key.Y: MenuItem_Powtorz_Click(sender, null); e.Handled = true; break;
                    case Key.X: MenuItem_Wytnij_Click(sender, null); e.Handled = true; break;
                    case Key.C: MenuItem_Kopiuj_Click(sender, null); e.Handled = true; break;
                    case Key.V: MenuItem_Wklej_Click(sender, null); e.Handled = true; break;
                    case Key.A: MenuItem_ZaznaczWszystko_Click(sender, null); e.Handled = true; break;
                }
            }
        }
    }
}
