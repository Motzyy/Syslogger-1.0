using System;
using System.Collections.Generic;
using InfluxData.Net.InfluxDb.Models;
using InfluxData.Net.InfluxDb;
using InfluxData.Net.Common.Enums;

namespace Syslogger
{
    /// <summary>
    /// Dient dazu sich mit einer DB zu verbinden,
    /// Logeinträge zu erstellen und diese dann entweder einzeln
    /// oder automatisiert zu versenden
    /// </summary>
    public class Syslogger
    {
        private InfluxDbClient influxDbClient;
        private Point pointToWrite;

        /// <summary>
        /// Dient zum Herstellen einer Verbindung
        /// zur gewählten Datenbankadresse
        /// </summary>
        /// <param name="AdresseDB">Adresse der Datenbank</param>
        public void SysloggerCreateClient(string AdresseDB)
        {
            try
            {
                influxDbClient = new InfluxDbClient(AdresseDB, " ", " ", InfluxDbVersion.v_1_3);
            }
            catch
            {
                throw new Exception("Der eingegebene Server existiert nicht!");
            }
            
        }

        /// <summary>
        /// Hier wird der Logeintrag im syslog Standard erstellt
        /// </summary>
        /// <param name="Appname">Name der App</param>
        /// <param name="Facility">Ursprung des Logs</param>
        /// <param name="Host">Host</param>
        /// <param name="Hostname">Hostname</param>
        /// <param name="severitylevel">Einstufung der Priorität</param>
        /// <param name="facilitycode">Code des Ursprungs</param>
        /// <param name="message">Nachricht</param>
        /// <param name="procid">Prozess ID</param>
        public void CreateMessage(string Appname,  string Host, string Hostname, int severitylevel, int facilitycode, string message, string procid)
        {
            string severity = DetermineSerevity(severitylevel);
            string facility = DetermineFacilty(facilitycode);

            pointToWrite = new Point()
            {
                Name = "syslog",
                Tags = new Dictionary<string, object>()
                    {
                        { "appname", Appname },
                        { "facility", facility},
                        { "host", Host },
                        { "hostname", Hostname},
                        { "severity", severity }

                    },
                Fields = new Dictionary<string, object>()
                {
                    { "facility_code", facilitycode },
                    { "severity_code", 1 },
                    { "version", 1 },
                    { "message", message },
                    { "procid", procid },
                    { "msgid", "testid"},
                    { "sdid", true },
                    { "timestamp", (Int64)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds * 1000000000}
                },
            };

        }

        /// <summary>
        /// Versendet die Nachricht einzeln sofern Sie erstellt wurde
        /// </summary>
        /// <param name="NameDB">Name der Zieldatenbank</param>
        public async void SendMessage(string NameDB)
        {
            try
            {
                var response = await influxDbClient.Client.WriteAsync(pointToWrite, NameDB);
                if (response.Success == true)
                    Console.WriteLine("Success");
                else
                    Console.WriteLine("No Success");
            }
            catch
            {
                throw new Exception("Die eingegebene Datenbank existiert nicht!");
            }

            GC.Collect();

        }

        /// <summary>
        /// Wird für automatisiertes Versenden von Nachrichten verwendet
        /// und arbeitet mit zufallsgenertierten Einträgen
        /// </summary>
        /// <param name="Host">Host</param>
        /// <param name="dbName">Name der Zieldatenbank</param>
        /// <param name="procid">Prozess ID</param>
        public void AutomatedSending(string Host, string dbName, string procid)
        {
            int seed = (int)DateTime.Now.Ticks;
            Randomize rnd = new Randomize(seed);
            rnd.Shuffle();
            CreateMessage(rnd.ReturnAppname(), Host, rnd.ReturnHostname(), rnd.ValueSev, rnd.ValueFac, "Automatisch generierter Text", procid);
            SendMessage(dbName);          
        }

        /// <summary>
        /// Dient dazu eine Messreihe zu löschen die 
        /// vom eingegebenen Host eingetragen wurde
        /// </summary>
        /// <param name="hostname">Name des Host</param>
        /// <param name="dbName">Name der Datenbank</param>
        public async void DeleteSeries(string hostname, string dbName)
        {
            string host = "host = '" + hostname + "'";
            IEnumerable<string> filter = new string[] { host};

            var response = await influxDbClient.Serie.DropSeriesAsync(dbName, "syslog", filter);
        }

        /// <summary>
        /// Wandelt den Severity Code in einen
        /// verständlichen String um
        /// </summary>
        /// <param name="lvl">Severity Level</param>
        /// <returns></returns>
        public string DetermineSerevity(int lvl)
        {
            string severity = "";
            switch (lvl)
            {
                case 0:
                    severity = "emerg";
                    break;
                case 1:
                    severity = "alert";
                    break;
                case 2:
                    severity = "crit";
                    break;
                case 3:
                    severity = "err";
                    break;
                case 4:
                    severity = "warning";
                    break;
                case 5:
                    severity = "notice";
                    break;
                case 6:
                    severity = "info";
                    break;
                case 7:
                    severity = "debug";
                    break;
            }
            return severity;
        }

        /// <summary>
        /// Wandelt den Facility Code in einen
        /// verständlichen String um
        /// </summary>
        /// <param name="facility_code">Facility Code</param>
        /// <returns></returns>
        public string DetermineFacilty(int facility_code)
        {
            switch (facility_code)
            {
                case 0:
                    return "kernel messages";
                case 1:
                    return "user-level messages";
                case 2:
                    return "mail system";
                case 3:
                    return "system daemons";
                case 4:
                    return "security/authorization messages";
                case 5:
                    return "messages generated internally by syslogd";
                case 6:
                    return "line printer subsystem";
                case 7:
                    return "network news subsystem";
                case 8:
                    return "UUCP subsystem";
                case 9:
                    return "clock daemon";
                case 10:
                    return "security/authorization messages";
                case 11:
                    return "FTP daemon";
                case 12:
                    return "NTP subsystem";
                case 13:
                    return "log audit";
                case 14:
                    return "log alert";
                case 15:
                    return "clock daemon";
                case 16:
                    return "local0";
                case 17:
                    return "local1";
                case 18:
                    return "local2";
                case 19:
                    return "local3";
                case 20:
                    return "local4";
                case 21:
                    return "local5";
                case 22:
                    return "local6";
                case 23:
                    return "local7";
            }

            return "error";
        }

    }

    }

