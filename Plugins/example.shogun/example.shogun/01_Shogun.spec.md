Masterdokument zur Spezifikation des Systems "ShogunEngine".
//import "02_SystemKontext.spec" .
//import "03_Glossar.spec".



Zweck des zu spezifizierenden Systems
=====================================

Liste der Ziele:

* [LiveSpiel] "Allgemeinziel" "Das System soll zwei Spielern die Möglichkeit eines zeitgleichen
 Spieles bieten." 
* [FernSpiel] "Allgemeinziel" "Das System soll zwei Spielern über ein Netzwerk ein zeitversetztes
 Spiel ermöglichen."
 
Abgrenzung der Ziele:

* [NoDroid] "Allgemeinziel" Kein Ziel ist ", dass ein Spieler gegen eine Computer Engine spielt
 bzw. das System bietet keine Engine als Gegenspieler an." 
  
Liste der Stakeholder:

* [Softwareentwickler] "Interessierte Entwickler welche in ihrer Freizeit im Open Source
 Bereich tätig sind und nach einem neuen Projekt suchen." 
* [Spieler]  "Möchte das Spiel spielen wo und wann er will. Er möchte seinen PC starten und losspielen.
 Falls kein Gegenspieler vor Ort verfügbar ist, möchte er sich im Internet einen anderen Spieler 
 suchen können und gegen diesen Spielen."


 
Systemkontext
=============

Liste der Systeme:

 * System [ShogunEngine] wird durch diese Spezifikation beschrieben.
 * Fremdsystem [Netzwerk] "Über ein Netzwerk können verschiedene Spielinstanzen Peer2Peer
 verbunden werden."

Glossar
=======

Liste der Begriffe:
*  [Spieler] "Koordiniert die Bewegung von Shogun Steinen einer Farbe. Zum Spiel werden 2 Spieler
 benötigt."
*  [Brett] "Das Spielbrett besteht aus  8x8 Feldern (wie ein Schachbrett)." 
*  [Steine] "Zum Spiel werden 7 rote und 7 weiße Spielsteine benötigt. Außerdem werden noch 1 roter
 und ein weißer Shogun Stein benötigt."
*  [Shogun] "Shogun stammt aus dem Japanischen und bezeichnet einen Feldherren."
*  [Spielende] "Das Spielende ist gekennzeichnet durch ..."
 
 
Liste der Abkürzungen:
 
* [unknowId] "nichts definiert"
 

Liste der Prozesse:

* Externer Prozess [ExtProzess] = "Das System kann in externe Prozesse eingebunden sein, diese sollen 
hier beschrieben werden."
* Interner Prozess [StellungSpeichern] = "Das Brett und die aktuelle Position der Spielsteine 
wird gespeichert" Prozesswort: "speichern"

 
 
Liste der Prozesswörter:

* [speichern] = "Persistieren von Daten" Synomyme: "sichern" "archivieren"
* [initialisieren] = "Erstellen von Feld und Grundposition der Steine" Synomyme: -
* [ziehen] = "Bewegen eines Spielsteines. Jeder Stein besitz einen aktuellen Augenwert. Damit darf jeder Stein
soviel Felder bewegt werden wie seinem Augenwert entsprechen" Synomyme: "bewegen"
   
Liste der Ereignisse:

*  [Absturz] = "Das Programm wird unerwartet beendet."
*  [Programmstart] = "Das System wird gestartet und weiß ist am Zug."
*  [Start] = "Das Programm und seine Komponenten werden intialisiert" 
    
Beschreibung der Anforderungen
==============================

1. [Robustheit] Bei Ereignis [Absturz] "sollte" "das System das" [Brett] [speichern].
1. [Start] Das System "muss" "die Steine und das" [Brett] [initialisieren].
1. [Ende] [Spielende] "wird" "die Stellung bezeichnet in der ein Spieler keine" [Steine] [ziehen] .





     
  
  
 