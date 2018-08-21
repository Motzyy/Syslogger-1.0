# Syslogger-1.0
Das Programm dient dazu Lognachrichtne im syslog Standard in eine InfluxDB zu schreiben.
Man kann hierbei zwischen drei Modi unterscheiden: Einzeln, automatischer und dauerhafter Modus.

## Getting Started

Das Projekt kann in Visual Studio kompiliert werden. Vorraussetzung ist hierfür:
* [InfluxData.Net](https://github.com/pootzko/InfluxData.Net#api-reference) - Die verwendete .NET Bibliothek für InfluxDB
* [System.Net.Http](https://www.nuget.org/packages/System.Net.Http/) - Die verwendete HTTP Bibliothek
* [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) - Die verwendete Json Bibliothek

## Senden von Logs
### Senden einzelner Logs
Um einzelne Logs zu senden darf kein Haken im Kontrollkästchen 'Automatischer Modus' gesetzt sein.
Folgende Modifikationen können vorgenommen werden:
* **Appname** - Hier kann der Name der Applikation eingetragen werden
* **Facility** - Bezeichnet den Ursprung der Nachricht, kann durch Facility Code geändert werden
* **Host** - System, dass den Log versendet hat
* **Hostname** - Name des Systems
* **Severity Level** - Schweregrad der zur Einstufung dient (0-7)
* **Facility Code** - Gibt die Quelle der Nachricht an (0-23)
* **ProcID.** - Prozess ID, die frei gewählt werden kann
* **Message** - Nachricht, die eine genauere Beschreibung der Lognachricht beinhalten
* **Adresse der DB** - Adresse der Datenbank (muss im HTTP Format gegeben werden, eg. http://localhost:8086)
* **Name der DB** - Name der Datenbank

Durch betätigen des 'Senden'-Buttons wird dann eine einzelne Nachricht mit den getätigten Einstellungen versendet

### Automatisches Senden
Wird ein Haken bei 'Automatischer Modus' gesetzt, so erscheinen folgende Felder:
* **Dauerhaftes Senden** - Wird hier ein Haken gesetzt so geht das Programm in den Modus des dauerhaften Sendens über
* **Anzahl Nachrichten** - Hier kann man die Anzahl der zu sendenden Nachrichten angeben
* **Interval (ms)** - Gibt den Zeitraum an, der zwischen dem Versenden zweier Nachrichten liegen soll

Im automatischen Modus werden viele Eigenschaften der Lognachricht zufallsgeneriert, somit kann man nur noch
den Host und die ProcID. festlegen.
Durch betätigen des 'Senden'-Buttons werden die Nachrichten mit den getätigten Einstellungen versendet. 
Man kann den Vorgang mit dem ''Abbrechen'-Button beenden.


### Dauerhaftes Senden
Ist der automatische Modus aktiv und ein Haken bei 'Dauerhaftes Senden' aktiv so wird auch das Feld 'Anzahl Nachrichten' deaktiviert,
da in diesem Modus dauerhaft Nachrichten im eingestellten Intervall versendet werden. Auch diese Nachrichten werden zufallsgeneriert
und lässt dem Benutzer die gleichen Konfigurationsmöglichkeiten wie im automatischen Modus.
Durch betätigen des 'Senden'-Buttons werden die Nachrichten mit den getätigten Einstellungen versendet. 
Man kann den Vorgang mit dem ''Abbrechen'-Button beenden.

## Löschen von Logs
Hier können Logeinträge eines bestimmten Hosts gelöscht werden. Man hat folgende Optionen:
* **Adresse der DB** - Adresse der Datenbank (muss im HTTP Format gegeben werden, eg. http://localhost:8086)
* **Name der DB** - Name der Datenbank
* **Host** - Name des Host von welchem die Logeinträge gelöscht werden sollen

Der Vorgang wird mit dem Button 'Delete' gestartet und muss daraufhin bestätigt werden.

