using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TPCWareListViewDemo.Model;

namespace TPCWareListViewDemo.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Appuntamento> MyItemList { get; set; }
        public MainViewModel()
        {
            MyItemList = new ObservableCollection<Appuntamento>();
            InitializeList();
        }

        private void InitializeList()
        {
            // In questo esempio non è necessario cancellare tutti gli elementi della lista
            // ma è importante sapere che non bisogna mai creare una nuova lista quanto piuttosto
            // cancellare gli elementi di quella creata nel costruttore (o nella definizione stessa)
            // perché altrimenti si perde il binding.
            MyItemList.Clear();

            // Qui istanziamo direttamente i valori, ma solitamente vengono recuperati da un servizio
            // utilizzando un'operazione asincrona, che quindi viene lanciata non dal costruttore,
            // ma dalla view che chiama il metodo del view model a seguito di un evento (tipicamente
            // l'evento "OnAppearing" della view).
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
