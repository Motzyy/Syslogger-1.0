using System;
using System.Threading;
using System.Windows.Forms;

namespace SysloggerGUI
{
    /// <summary>
    /// Die Hauptseite des GUIs
    /// </summary>
    public partial class SysloggerGUI : Form
    {
        public Syslogger.Syslogger syslogger;

        /// <summary>
        /// Initialiseren der Komponenten und Klassen
        /// sowie abonnieren der backgroundWorker Events
        /// </summary>
        public SysloggerGUI()
        {
            InitializeComponent();
            CheckEnableButton();
            syslogger = new Syslogger.Syslogger();

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;  
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        /// <summary>
        /// Wenn der Button 'Senden' gedrückt wurde wird in dieser Methode
        /// entschieden ob ein einzelner Log, eine Reihe von Logs oder
        /// dauerhaft Logs versendet werden
        /// </summary>
        public void button3_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = true;
            button3.Enabled = false;
            syslogger.SysloggerCreateClient(textBoxAdresseDB.Text);
            if (checkBoxAuto.Checked == false)
            {
                syslogger.CreateMessage(textBoxAppname.Text, textBoxHost.Text, textBoxHostname.Text, (int)numericUpDownSeverity.Value, (int)numericUpDownFacility.Value, textBoxMessage.Text, textBoxProc.Text);
                syslogger.SendMessage(textBoxNameDB.Text);
                buttonCancel.Enabled = false;
                button3.Enabled = true;
            }
            else
                backgroundWorker1.RunWorkerAsync();
            

        }

        /// <summary>
        /// Der BackgroundWorker arbeitet in den automatisierten
        /// Sendevorgängen, damit das Programm sich nicht aufhängt und
        /// sich der Vorgang abbrechen lässt
        /// Nebenbei wird der Prozessfortschritt an eine ProgressBar gesendet
        /// damit man sieht wie weit der Prozess vorangeschritten ist
        /// </summary>
        public void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (checkBoxPerm.Checked == false)
            {
                for (int i = 1; i < (int)numericUpDownCount.Value + 1; i++)
                {
                    syslogger.AutomatedSending(textBoxHost.Text, textBoxNameDB.Text, textBoxProc.Text);
                    Thread.Sleep((int)numericUpDownInterval.Value);
                    float zwischenwert = (i / (float)numericUpDownCount.Value) * 100;
                    backgroundWorker1.ReportProgress((int)((i/ (float)numericUpDownCount.Value) * 100));
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
            }
            else
            {
                double i = 0;
                while (true)
                {
                    syslogger.AutomatedSending(textBoxHost.Text, textBoxNameDB.Text, textBoxProc.Text);
                    Thread.Sleep((int)numericUpDownInterval.Value);
                    backgroundWorker1.ReportProgress((int) i);
                    i = i + 0.2;
                    if (i > 99.5)
                        i = 0.0;
                    if (backgroundWorker1.CancellationPending)
                    {
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Der übermittelte Wert des Fortschritts wird der ProgressBar zugeordnet
        /// </summary>
        public void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// Ist der Vorgang abgeschlossen, so wird der Button 'Senden'
        /// wieder freigegeben damit ein neuer Prozess gestartet werden
        /// kann
        /// </summary>
        public void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            buttonCancel.Enabled = false;
            button3.Enabled = true;
        }

        /// <summary>
        /// In dieser Region wird dafür gesorgt, dass der Button senden
        /// nur aktiviert ist, wenn in allen notwendigen TextBoxes
        /// Inhalt steht
        /// </summary>
        #region Update Send Button
        public void CheckEnableButton()
        {
            if (textBoxAppname.TextLength > 0 && textBoxFacility.TextLength > 0 && textBoxHost.TextLength > 0 && textBoxHostname.TextLength > 0 && textBoxMessage.TextLength > 0 && textBoxAdresseDB.TextLength > 0 && textBoxNameDB.TextLength > 0)
                button3.Enabled = true;
            else
                button3.Enabled = false;
        }

        public void textBoxAppname_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        public void textBoxFacility_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        public void textBoxHost_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        public void textBoxHostname_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        public void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        public void textBoxNameDB_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        public void textBoxAdresseDB_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }
        #endregion

        /// <summary>
        /// Hier wird das Interface, je nach gewähltem Modus angepasst,
        /// sodass nur noch die Felder aktiv sind, die auch den Log beeinflussen
        /// </summary>
        #region Update Interface
        public void numericUpDownSeverity_ValueChanged(object sender, EventArgs e)
        {
            labelSeverity.Text = syslogger.DetermineSerevity((int)numericUpDownSeverity.Value);
        }

        public void numericUpDownFacility_ValueChanged(object sender, EventArgs e)
        {
            labelFacility.Text = syslogger.DetermineFacilty((int)numericUpDownFacility.Value);
            
            if(numericUpDownFacility.Value > 15)
                textBoxFacility.ReadOnly = false;
            else
                textBoxFacility.ReadOnly = true;

        textBoxFacility.Text = labelFacility.Text;
        }

        public void checkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAuto.Checked == true)
            {
                checkBoxPerm.Visible = true;
                labelInterval.Visible = true;
                numericUpDownInterval.Visible = true;
                labelCount.Visible = true;
                numericUpDownCount.Visible = true;
                textBoxAppname.Enabled = false;
                textBoxHostname.Enabled = false;
                textBoxMessage.Enabled = false;
                progressBar1.Visible = true;
                numericUpDownFacility.Enabled = false;
                numericUpDownSeverity.Enabled = false;
            }
            else
            {
                checkBoxPerm.Visible = false;
                labelInterval.Visible = false;
                numericUpDownInterval.Visible = false;
                labelCount.Visible = false;
                numericUpDownCount.Visible = false;
                textBoxAppname.Enabled = true;
                textBoxHostname.Enabled = true;
                textBoxMessage.Enabled = true;
                progressBar1.Visible = false;
                numericUpDownFacility.Enabled = true;
                numericUpDownSeverity.Enabled = true;
            }
        }

        public void checkBoxPerm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPerm.Checked == true)
            {
                numericUpDownCount.Enabled = false;

            }
                
            else
            {
                numericUpDownCount.Enabled = true;

            }
            
        }
        #endregion

        /// <summary>
        /// Startet nach Bestätigen der MessageBox den 
        /// Vorgang zum Löschen einer Logreihe
        /// </summary>
        public void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie das wirklich unwiderruflich löschen?", "Löschen einer Messreihe",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                syslogger.DeleteSeries(textBoxHostnameDelete.Text, textBoxNameDBdelete.Text);
            }

        }

        /// <summary>
        /// Bricht einen laufenden Sendevorgang ab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }

        }


        #region Nicht genutzte Funktionen
        public void labelInterval_Click(object sender, EventArgs e)
        {

        }

        public void labelCount_Click(object sender, EventArgs e)
        {

        }

        public void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {

        }

        public void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
