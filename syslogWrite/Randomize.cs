using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syslogWrite
{
    /// <summary>
    /// Die Klasse dient dazu zufallsgenerierte
    /// Werte für das automatisierte Senden
    /// zu erstellen
    /// </summary>
    public class Randomize
    {
        private Random rnd;
        private int Value1;
        private int Value2;
        public int ValueSev;
        public int ValueFac;

        /// <summary>
        /// Initialisiert die Klasse mit einem Seed,
        /// welcher dafür sorgt, dass wir garantiert zufällige
        /// Werte erhalten
        /// </summary>
        /// <param name="seed">Sorgt für garantiert zufällige Werte</param>
        public Randomize(int seed)
        {
            rnd = new Random(seed);
            Value1 = rnd.Next(1, 10);
            Value2 = rnd.Next(1, 10);
            ValueSev = rnd.Next(0, 7);
            ValueFac = rnd.Next(0, 23);
        }

        /// <summary>
        /// Dient dazu neue Zufallswerte zuzuordnen
        /// </summary>
        public void Shuffle()
        {
            Value1 = rnd.Next(1, 10);
            Value2 = rnd.Next(1, 10);
            ValueSev = rnd.Next(0, 7);
            ValueFac = rnd.Next(0, 23);
        }

        /// <summary>
        /// Wandelt die Zufallszahl in einen Appnamen um
        /// </summary>
        /// <returns>Name der App</returns>
        public string ReturnAppname()
        {
            string appname = " ";
            switch (Value1)
            {
                case 1:
                    appname = "App1";
                    break;
                case 2:
                    appname = "App2";
                    break;
                case 3:
                    appname = "App3";
                    break;
                case 4:
                    appname = "App4";
                    break;
                case 5:
                    appname = "App5";
                    break;
                case 6:
                    appname = "App6";
                    break;
                case 7:
                    appname = "App7";
                    break;
                case 8:
                    appname = "App8";
                    break;
                case 9:
                    appname = "App9";
                    break;
                case 10:
                    appname = "App10";
                    break;
            }
            return appname;
        }

        /// <summary>
        /// Wandelt die Zufallszahl in einen Hostnamen um
        /// </summary>
        /// <returns>Name des Host</returns>
        public string ReturnHostname()
        {
            string hostname = " ";
            switch(Value2)
            {
                case 1:
                    hostname = "host1";
                    break;
                case 2:
                    hostname = "host2";
                    break;
                case 3:
                    hostname = "host3";
                    break;
                case 4:
                    hostname = "host4";
                    break;
                case 5:
                    hostname = "host5";
                    break;
                case 6:
                    hostname = "host6";
                    break;
                case 7:
                    hostname = "host7";
                    break;
                case 8:
                    hostname = "host8";
                    break;
                case 9:
                    hostname = "host9";
                    break;
                case 10:
                    hostname = "host10";
                    break;
            }
            return hostname;
        }
    }
}
