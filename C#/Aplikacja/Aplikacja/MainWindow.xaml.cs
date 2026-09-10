using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Win32;
using System.IO;
using System.Linq;

namespace Aplikacja
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ShoppingItem> Items { get; set; } = new();
        private ObservableCollection<ShoppingItem> _filteredItems = new();
        public ObservableCollection<ShoppingItem> FilteredItems
        {
            get => _filteredItems;
            set
            {
                _filteredItems = value;
                OnPropertyChanged();
            }
        }
        public string NewItemName { get; set; }
        public List<string> Categories { get; set; } = new()
        {
            "Jedzenie", "Chemia", "Inne"
        };
        public List<string> Filters { get; set; } = new()
        {
            "Wszystkie", "Kupione", "Niekupione"
        };
        private string _SelectedCategory;
        public string SelectedCategory
        {
            get => _SelectedCategory;
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }
        }
        private string _SelectedFilter = "Wszystkie";
        public string SelectedFilter
        {
            get => _SelectedFilter;
            set
            {
                _SelectedFilter = value;
                OnPropertyChanged();
                ApplyFilter();
            }
        }
        public MainViewModel()
        {
            SelectedCategory = "Inne";

        }
        public void AddItem()
        {
            if (string.IsNullOrWhiteSpace(NewItemName))
                return;
            Items.Add(new ShoppingItem { Name = NewItemName, Category = SelectedCategory, IsBought = false });

            NewItemName = "";
            ApplyFilter();
            Save();
        }
        public void RemoveItem(ShoppingItem item)
        {
            Items.Remove(item);
            ApplyFilter();
            Save();
        }
        public void ApplyFilter()
        {
            IEnumerable<ShoppingItem> result = Items;
            if (SelectedFilter == "Kupione")
                result = Items.Where(x => x.IsBought);
            else if (SelectedFilter == "Niekupione")
                result = Items.Where(x => !x.IsBought);
            FilteredItems = new ObservableCollection<ShoppingItem>(result);
        }
        public void Save()
        {
            var json = JsonSerializer.Serialize(Items);
            File.WriteAllText("shopping.json", json);
        }
        public void Load()
        {
            if (!File.Exists("shopping.json"))
            {
                ApplyFilter();
                return;
            }
            var json = File.ReadAllText("shopping.json");
            var items = JsonSerializer.Deserialize<List<ShoppingItem>>(json);

            Items.Clear();

            foreach (var i in items)
                Items.Add(i);

            ApplyFilter();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}