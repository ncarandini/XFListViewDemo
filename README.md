# XFListViewDemo
Una semplice demo per rispondere a una richiesta di aiuto su come selezionare un elemento di una lista via codice:

<img src="https://user-images.githubusercontent.com/139274/51092431-6bf17e80-1797-11e9-8571-04b4c99eee3c.jpg" width="300" />


### Nota bene
Questo non è codice da usare in produzione!

In particolare, nella branch `no_mvvm` non ho utilizzato MVVM per non complicare il codice e rimanere focalizzato sul tema, con il binding fatto direttamente sulla proprietà `MyItemList` della classe stessa (cosa da non fare mai).

Invece nella branch principale `master` ho utilizzato mvvm pur mantenendo l'implementazione degli eventi dei bottoni nella view e omettendo di utilizzare ICommand, sempre per mantenere semplice l'esempio.


