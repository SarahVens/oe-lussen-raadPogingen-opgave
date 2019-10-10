oe-lussen-raadPogingen-start
Laat de computer een door de gebruiker ingegeven getal raden en maak deze applicatie zo fool proof mogelijk.

# Raadpogingen
## Bij het opstarten
- In lblMax wordt de waarde van MAX_GETAL getoond.
- De cursor wordt in txtTeRaden geplaatst.
## Bij een klik op btnRaad
- Zal de computer de volgende handelingen uitvoeren tot het te raden getal gevonden is.
  - In *gok* wordt een willekeurig opgeslagen van 1 t.e.m. MAX_GETAL.
  - Deze gok wordt bovenaan in lstGokjes toegevoegd
  - Het aantal pogingen wordt met 1 verhoogd
- Eens het getal gevonden is worden de handelingen stopgezet en
  - wordt er aangegeven in hoeveel pogingen het getal gevonden is
  - komt de cursor in txtTeRaden en wordt de volledige input in txtTeRaden geselecteerd.
## Fool proof maken
Er kunnen bij dit programma enkele zaken fout lopen
- het ingetikte getal kan te groot of te klein zijn, waardoor je in een oneindige lus terecht kunt komen
- de gebruiker kan txtTeRaden leeg laten
- de gebruiker kan iets intikken dat helemaal geen getal is
Schrijf de nodige code die deze app 'uncrashable' maakt.
## Gebruikersvriendelijk maken
Zorg ervoor dat de gebruiker nooit moet klikken in txtTeRaden.
Wis verkeerde input in txtTeRaden automatisch.
Bij geldige input zal na het raden de Text geselecteerd worden.
 
