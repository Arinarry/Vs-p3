using ItemsControlWrapPanelExample.Models;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace ItemsControlWrapPanelExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<CityEvent> _items;

        public List<CityEvent> Items
        {
            get { return _items; }
            set { this.RaiseAndSetIfChanged(ref _items, value); }
        }
        public ObservableCollection<CityEvent> ChildrenEvents { get; set; }
        public ObservableCollection<CityEvent> SportEvents { get; set; }
        public ObservableCollection<CityEvent> CultureEvents { get; set; }
        public ObservableCollection<CityEvent> ExcursionEvents { get; set; }
        public ObservableCollection<CityEvent> LifestyleEvents { get; set; }
        public ObservableCollection<CityEvent> PartyEvents { get; set; }
        public ObservableCollection<CityEvent> EducationEvents { get; set; }
        public ObservableCollection<CityEvent> OnlineEvents { get; set; }
        public ObservableCollection<CityEvent> ShowEvents { get; set; }

        public MainWindowViewModel()
        {
            Items = CityEventDatabase.Load();
            ChildrenEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Children));
            SportEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Sport));
            CultureEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Culture));
            ExcursionEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Excursion));
            LifestyleEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Lifestyles));
            PartyEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Party));
            EducationEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Education));
            OnlineEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Online));
            ShowEvents = new ObservableCollection<CityEvent>(Items.Where(e => e.Category == CityEvent.category.Show));
        }
    }
}