# Esercitazione 17: Supermercato Completo

## Obiettivo

- Implementare un programma che cimuli il funzionamento di un supermercato.
- Il programma deve permettere ad un opertore di:
  - Gestire un catalogo di prodotti ( Gestire prodorri del catalogo. Salvare e caricare il catalogo dei prodotti da un file JSON)
- Il programma deve Permettere a un cliente di riempire il proprio carello della spesa
- Calcolara il totale del carello e stampare un scontrino

## Funzionalita:

Gestione del catalogo prodotti: (operazione CRUD):
  - Il codice prodotto
  - Nome prodotto
  - Prezzo
  - Quantità disponibile (in magazzino che viene decrementata quando un cliente acquista un prodotto)


Gestione del carello e dello scontrino del cliente:
  - Data di acquisto
  - Lista dei prodotti acquistati
  - Quantità per prodotto
  - Totale spesa

Gestione dello store:
  - Salvare il catalogo su file 
  - Caricare il catalogo dal file
  - Salvare lo scrontrino su file
  - Caricare lo scontrino dal file
  - Visuallizzare al catalogo dei prodotti
  - Visualizzare gli scontrini
  - Implementare alcuni filtri (es. prodotti con prezzo minore di un certo valore, prodotti acquistati in una certa data, ecc.)

## Implementazioni future:

- Gestione operatori del supermercato (anagrafica, ruoli, ecc.)
- Gestione clienti (anagrafica, storico, acquisti, ecc.)
- Gestione punti fedelta (es. sconti, premi, ecc.)
- Gestione magazzino (funzionalita di rifornimento, gestione sottoscorta, ecc.)