using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TPCWareListViewDemo
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Appuntamento> MyItemList { get; set; } = new ObservableCollection<Appuntamento>();

        public MainPage()
        {
            InitializeComponent();
            InitializeList();
        }

        private void FirstElementButton_Clicked(object sender, EventArgs e)
        {
            // seleziona il primo elemento nella lista
            var item = MyItemList.FirstOrDefault();
            MyListView.SelectedItem = item;
            MyListView.ScrollTo(item, ScrollToPosition.Center, animated: true);
        }

        private void FindDateButton_Clicked(object sender, EventArgs e)
        {
            DateTime findDateTime = new DateTime(2019, 01, 24);

            // Cerca il primo elemento con la data desiderata
            var item = MyItemList.Where(ap => ap.Data == findDateTime).FirstOrDefault();

            // seleziona l'elemento nella lista
            MyListView.SelectedItem = item;
            MyListView.ScrollTo(item, ScrollToPosition.Center, animated: true);
        }

        private void InitializeList()
        {
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 8),
                Descrizione = "Cena di gala"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 10),
                Descrizione = "Cinema"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 12),
                Descrizione = "Pizza"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 13),
                Descrizione = "Xbox One con gli amici"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 14),
                Descrizione = "Tennis"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 17),
                Descrizione = "Teatro"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 18),
                Descrizione = "Mostra fotografica"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 19),
                Descrizione = "Pizza"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 20),
                Descrizione = "Cena con gli amici"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 22),
                Descrizione = "Cena di lavoro"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 23),
                Descrizione = "Preparare le slide"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 24),
                Descrizione = "Partita di calcetto"
            });
            MyItemList.Add(new Appuntamento
            {
                Data = new DateTime(2019, 01, 29),
                Descrizione = "Meetup"
            });
        }
    }
}