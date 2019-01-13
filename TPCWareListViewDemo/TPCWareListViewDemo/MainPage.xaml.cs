using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPCWareListViewDemo.ViewModel;
using Xamarin.Forms;

namespace TPCWareListViewDemo
{
    public partial class MainPage : ContentPage
    {
        // Predisponiamo una variabile per referenziare il viewmodel
        private MainViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            // prendiamo il riferimento al viewmodel dalla proprietà "BindingContext" della view
            // (che abbiamo impostato in XAML) facendone il cast al nostro tipo di viewmodel
            // perché la proprietà "BindingContext" è di tipo object.
            vm = BindingContext as MainViewModel;
        }

        // I puristi del MVVM qui storcono certamente il naso, perché andrebbe utilizzato ICommand per spostare tutta la logica nel viewmodel
        // e io sono d'accordo perché rende tutto testabile con gli unit test. Questa però è solo una demo, quindi per semplicità lascio qui il codice.

        private void FirstElementButton_Clicked(object sender, EventArgs e)
        {
            // seleziona il primo elemento nella lista
            var item = vm.MyItemList.FirstOrDefault();
            MyListView.SelectedItem = item;
            MyListView.ScrollTo(item, ScrollToPosition.Center, animated: true);
        }

        private void FindDateButton_Clicked(object sender, EventArgs e)
        {
            DateTime findDateTime = new DateTime(2019, 01, 24);

            // Cerca il primo elemento con la data desiderata
            var item = vm.MyItemList.Where(ap => ap.Data == findDateTime).FirstOrDefault();

            // seleziona l'elemento nella lista
            MyListView.SelectedItem = item;
            MyListView.ScrollTo(item, ScrollToPosition.Center, animated: true);
        }

    }
}