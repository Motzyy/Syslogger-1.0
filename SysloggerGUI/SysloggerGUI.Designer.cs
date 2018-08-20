namespace SysloggerGUI
{
    partial class SysloggerGUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAppname = new System.Windows.Forms.TextBox();
            this.textBoxFacility = new System.Windows.Forms.TextBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAdresseDB = new System.Windows.Forms.TextBox();
            this.textBoxNameDB = new System.Windows.Forms.TextBox();
            this.numericUpDownSeverity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFacility = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSeverity = new System.Windows.Forms.Label();
            this.labelFacility = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNameDBdelete = new System.Windows.Forms.TextBox();
            this.textBoxAdresseDBDelete = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxHostnameDelete = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxPerm = new System.Windows.Forms.CheckBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxProc = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFacility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appname";
            this.toolTip1.SetToolTip(this.label1, "Name der App");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hostname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Severity Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Facility Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Message";
            // 
            // textBoxAppname
            // 
            this.textBoxAppname.Location = new System.Drawing.Point(169, 109);
            this.textBoxAppname.Name = "textBoxAppname";
            this.textBoxAppname.Size = new System.Drawing.Size(202, 22);
            this.textBoxAppname.TabIndex = 7;
            this.textBoxAppname.Text = "Test";
            this.textBoxAppname.TextChanged += new System.EventHandler(this.textBoxAppname_TextChanged);
            // 
            // textBoxFacility
            // 
            this.textBoxFacility.Location = new System.Drawing.Point(169, 142);
            this.textBoxFacility.Name = "textBoxFacility";
            this.textBoxFacility.ReadOnly = true;
            this.textBoxFacility.Size = new System.Drawing.Size(202, 22);
            this.textBoxFacility.TabIndex = 8;
            this.textBoxFacility.Text = "kernel messages";
            this.textBoxFacility.TextChanged += new System.EventHandler(this.textBoxFacility_TextChanged);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(169, 174);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(202, 22);
            this.textBoxHost.TabIndex = 9;
            this.textBoxHost.Text = "Test";
            this.textBoxHost.TextChanged += new System.EventHandler(this.textBoxHost_TextChanged);
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(169, 203);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(202, 22);
            this.textBoxHostname.TabIndex = 10;
            this.textBoxHostname.Text = "Test";
            this.textBoxHostname.TextChanged += new System.EventHandler(this.textBoxHostname_TextChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(544, 106);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(187, 53);
            this.textBoxMessage.TabIndex = 13;
            this.textBoxMessage.Text = "Test";
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Adresse der DB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name der DB";
            // 
            // textBoxAdresseDB
            // 
            this.textBoxAdresseDB.Location = new System.Drawing.Point(544, 171);
            this.textBoxAdresseDB.Name = "textBoxAdresseDB";
            this.textBoxAdresseDB.Size = new System.Drawing.Size(187, 22);
            this.textBoxAdresseDB.TabIndex = 18;
            this.textBoxAdresseDB.Text = "http://localhost:8086";
            this.textBoxAdresseDB.TextChanged += new System.EventHandler(this.textBoxAdresseDB_TextChanged);
            // 
            // textBoxNameDB
            // 
            this.textBoxNameDB.Location = new System.Drawing.Point(544, 199);
            this.textBoxNameDB.Name = "textBoxNameDB";
            this.textBoxNameDB.Size = new System.Drawing.Size(187, 22);
            this.textBoxNameDB.TabIndex = 19;
            this.textBoxNameDB.Text = "TestDB";
            this.textBoxNameDB.TextChanged += new System.EventHandler(this.textBoxNameDB_TextChanged);
            // 
            // numericUpDownSeverity
            // 
            this.numericUpDownSeverity.Location = new System.Drawing.Point(171, 233);
            this.numericUpDownSeverity.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownSeverity.Name = "numericUpDownSeverity";
            this.numericUpDownSeverity.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownSeverity.TabIndex = 20;
            this.numericUpDownSeverity.ValueChanged += new System.EventHandler(this.numericUpDownSeverity_ValueChanged);
            // 
            // numericUpDownFacility
            // 
            this.numericUpDownFacility.Location = new System.Drawing.Point(169, 293);
            this.numericUpDownFacility.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownFacility.Name = "numericUpDownFacility";
            this.numericUpDownFacility.Size = new System.Drawing.Size(202, 22);
            this.numericUpDownFacility.TabIndex = 21;
            this.numericUpDownFacility.ValueChanged += new System.EventHandler(this.numericUpDownFacility_ValueChanged);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(417, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Senden";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Severity Exp.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Facility Exp.";
            // 
            // labelSeverity
            // 
            this.labelSeverity.AutoSize = true;
            this.labelSeverity.Location = new System.Drawing.Point(168, 264);
            this.labelSeverity.Name = "labelSeverity";
            this.labelSeverity.Size = new System.Drawing.Size(48, 17);
            this.labelSeverity.TabIndex = 25;
            this.labelSeverity.Text = "emerg";
            // 
            // labelFacility
            // 
            this.labelFacility.AutoSize = true;
            this.labelFacility.Location = new System.Drawing.Point(168, 322);
            this.labelFacility.Name = "labelFacility";
            this.labelFacility.Size = new System.Drawing.Size(115, 17);
            this.labelFacility.TabIndex = 26;
            this.labelFacility.Text = "kernel messages";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(37, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Löschen der Inhalte";
            // 
            // textBoxNameDBdelete
            // 
            this.textBoxNameDBdelete.Location = new System.Drawing.Point(167, 454);
            this.textBoxNameDBdelete.Name = "textBoxNameDBdelete";
            this.textBoxNameDBdelete.Size = new System.Drawing.Size(187, 22);
            this.textBoxNameDBdelete.TabIndex = 31;
            this.textBoxNameDBdelete.Text = "TestDB";
            // 
            // textBoxAdresseDBDelete
            // 
            this.textBoxAdresseDBDelete.Location = new System.Drawing.Point(167, 426);
            this.textBoxAdresseDBDelete.Name = "textBoxAdresseDBDelete";
            this.textBoxAdresseDBDelete.Size = new System.Drawing.Size(187, 22);
            this.textBoxAdresseDBDelete.TabIndex = 30;
            this.textBoxAdresseDBDelete.Text = "http://localhost:8086";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 459);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Name der DB";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(37, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Adresse der DB";
            // 
            // textBoxHostnameDelete
            // 
            this.textBoxHostnameDelete.Location = new System.Drawing.Point(168, 485);
            this.textBoxHostnameDelete.Name = "textBoxHostnameDelete";
            this.textBoxHostnameDelete.Size = new System.Drawing.Size(187, 22);
            this.textBoxHostnameDelete.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 490);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Host";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(416, 467);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 40);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Senden von Logs";
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(38, 57);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(166, 21);
            this.checkBoxAuto.TabIndex = 36;
            this.checkBoxAuto.Text = "Automatischer Modus";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // checkBoxPerm
            // 
            this.checkBoxPerm.AutoSize = true;
            this.checkBoxPerm.Location = new System.Drawing.Point(210, 57);
            this.checkBoxPerm.Name = "checkBoxPerm";
            this.checkBoxPerm.Size = new System.Drawing.Size(161, 21);
            this.checkBoxPerm.TabIndex = 37;
            this.checkBoxPerm.Text = "Dauerhaftes Senden";
            this.checkBoxPerm.UseVisualStyleBackColor = true;
            this.checkBoxPerm.Visible = false;
            this.checkBoxPerm.CheckedChanged += new System.EventHandler(this.checkBoxPerm_CheckedChanged);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(414, 232);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(131, 17);
            this.labelCount.TabIndex = 38;
            this.labelCount.Text = "Anzahl Nachrichten";
            this.labelCount.Visible = false;
            this.labelCount.Click += new System.EventHandler(this.labelCount_Click);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(414, 266);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(86, 17);
            this.labelInterval.TabIndex = 39;
            this.labelInterval.Text = "Interval (ms)";
            this.labelInterval.Visible = false;
            this.labelInterval.Click += new System.EventHandler(this.labelInterval_Click);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(545, 232);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCount.TabIndex = 40;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCount.Visible = false;
            this.numericUpDownCount.ValueChanged += new System.EventHandler(this.numericUpDownCount_ValueChanged);
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(545, 264);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownInterval.TabIndex = 41;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Visible = false;
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Location = new System.Drawing.Point(587, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(144, 40);
            this.buttonCancel.TabIndex = 42;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(416, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(314, 23);
            this.progressBar1.TabIndex = 43;
            this.progressBar1.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "ProcID.";
            // 
            // textBoxProc
            // 
            this.textBoxProc.Location = new System.Drawing.Point(167, 353);
            this.textBoxProc.Name = "textBoxProc";
            this.textBoxProc.Size = new System.Drawing.Size(202, 22);
            this.textBoxProc.TabIndex = 45;
            this.textBoxProc.Text = "225";
            // 
            // SysloggerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.textBoxProc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.checkBoxPerm);
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxHostnameDelete);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxNameDBdelete);
            this.Controls.Add(this.textBoxAdresseDBDelete);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelFacility);
            this.Controls.Add(this.labelSeverity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDownFacility);
            this.Controls.Add(this.numericUpDownSeverity);
            this.Controls.Add(this.textBoxNameDB);
            this.Controls.Add(this.textBoxAdresseDB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxHostname);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.textBoxFacility);
            this.Controls.Add(this.textBoxAppname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SysloggerGUI";
            this.Text = "Syslogger";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeverity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFacility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAppname;
        private System.Windows.Forms.TextBox textBoxFacility;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxHostname;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAdresseDB;
        private System.Windows.Forms.TextBox textBoxNameDB;
        private System.Windows.Forms.NumericUpDown numericUpDownSeverity;
        private System.Windows.Forms.NumericUpDown numericUpDownFacility;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelSeverity;
        private System.Windows.Forms.Label labelFacility;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNameDBdelete;
        private System.Windows.Forms.TextBox textBoxAdresseDBDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxHostnameDelete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.CheckBox checkBoxPerm;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxProc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

