namespace fofGuitarController_driver
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConnectComPort = new System.Windows.Forms.Button();
            this.lstBxReceived = new System.Windows.Forms.ListBox();
            this.lblFret1 = new System.Windows.Forms.Label();
            this.lblFret2 = new System.Windows.Forms.Label();
            this.lblFret3 = new System.Windows.Forms.Label();
            this.lblFret4 = new System.Windows.Forms.Label();
            this.lblFret5 = new System.Windows.Forms.Label();
            this.lblPick = new System.Windows.Forms.Label();
            this.chkBxShowVisualFeedback = new System.Windows.Forms.CheckBox();
            this.lblMenuMode = new System.Windows.Forms.Label();
            this.lblUp = new System.Windows.Forms.Label();
            this.lblDown = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblGuitarMode = new System.Windows.Forms.Label();
            this.lblEscape = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblDataVolume = new System.Windows.Forms.Label();
            this.btnResetDataVolume = new System.Windows.Forms.Button();
            this.lblKeyStrokeCount = new System.Windows.Forms.Label();
            this.picBxMeasureDelayGraph = new System.Windows.Forms.PictureBox();
            this.lblMeasureDelayGraph = new System.Windows.Forms.Label();
            this.lblMeasureDelayMin = new System.Windows.Forms.Label();
            this.lblMeasureDelayMax = new System.Windows.Forms.Label();
            this.grpBxVisualFeedBack = new System.Windows.Forms.GroupBox();
            this.lstBxBTDevices = new System.Windows.Forms.ListBox();
            this.btnConnectBTDevice = new System.Windows.Forms.Button();
            this.btnSearchBTDevice = new System.Windows.Forms.Button();
            this.lblKeyStrokesPerSecond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBxMeasureDelayGraph)).BeginInit();
            this.grpBxVisualFeedBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnConnectComPort
            // 
            this.btnConnectComPort.Location = new System.Drawing.Point(165, 12);
            this.btnConnectComPort.Name = "btnConnectComPort";
            this.btnConnectComPort.Size = new System.Drawing.Size(113, 23);
            this.btnConnectComPort.TabIndex = 1;
            this.btnConnectComPort.Text = "Connect COM Port";
            this.btnConnectComPort.UseVisualStyleBackColor = true;
            this.btnConnectComPort.Click += new System.EventHandler(this.btnConnectComPort_Click);
            // 
            // lstBxReceived
            // 
            this.lstBxReceived.FormattingEnabled = true;
            this.lstBxReceived.Location = new System.Drawing.Point(740, 12);
            this.lstBxReceived.Name = "lstBxReceived";
            this.lstBxReceived.Size = new System.Drawing.Size(239, 277);
            this.lstBxReceived.TabIndex = 2;
            // 
            // lblFret1
            // 
            this.lblFret1.AutoSize = true;
            this.lblFret1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFret1.ForeColor = System.Drawing.Color.Gray;
            this.lblFret1.Location = new System.Drawing.Point(6, 294);
            this.lblFret1.Name = "lblFret1";
            this.lblFret1.Size = new System.Drawing.Size(64, 24);
            this.lblFret1.TabIndex = 3;
            this.lblFret1.Text = "Fret 1";
            // 
            // lblFret2
            // 
            this.lblFret2.AutoSize = true;
            this.lblFret2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFret2.ForeColor = System.Drawing.Color.Gray;
            this.lblFret2.Location = new System.Drawing.Point(92, 294);
            this.lblFret2.Name = "lblFret2";
            this.lblFret2.Size = new System.Drawing.Size(64, 24);
            this.lblFret2.TabIndex = 4;
            this.lblFret2.Text = "Fret 2";
            // 
            // lblFret3
            // 
            this.lblFret3.AutoSize = true;
            this.lblFret3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFret3.ForeColor = System.Drawing.Color.Gray;
            this.lblFret3.Location = new System.Drawing.Point(178, 294);
            this.lblFret3.Name = "lblFret3";
            this.lblFret3.Size = new System.Drawing.Size(64, 24);
            this.lblFret3.TabIndex = 5;
            this.lblFret3.Text = "Fret 3";
            // 
            // lblFret4
            // 
            this.lblFret4.AutoSize = true;
            this.lblFret4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFret4.ForeColor = System.Drawing.Color.Gray;
            this.lblFret4.Location = new System.Drawing.Point(264, 294);
            this.lblFret4.Name = "lblFret4";
            this.lblFret4.Size = new System.Drawing.Size(64, 24);
            this.lblFret4.TabIndex = 6;
            this.lblFret4.Text = "Fret 4";
            // 
            // lblFret5
            // 
            this.lblFret5.AutoSize = true;
            this.lblFret5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFret5.ForeColor = System.Drawing.Color.Gray;
            this.lblFret5.Location = new System.Drawing.Point(350, 294);
            this.lblFret5.Name = "lblFret5";
            this.lblFret5.Size = new System.Drawing.Size(64, 24);
            this.lblFret5.TabIndex = 7;
            this.lblFret5.Text = "Fret 5";
            // 
            // lblPick
            // 
            this.lblPick.AutoSize = true;
            this.lblPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPick.ForeColor = System.Drawing.Color.Gray;
            this.lblPick.Location = new System.Drawing.Point(178, 346);
            this.lblPick.Name = "lblPick";
            this.lblPick.Size = new System.Drawing.Size(49, 24);
            this.lblPick.TabIndex = 8;
            this.lblPick.Text = "Pick";
            // 
            // chkBxShowVisualFeedback
            // 
            this.chkBxShowVisualFeedback.AutoSize = true;
            this.chkBxShowVisualFeedback.Checked = true;
            this.chkBxShowVisualFeedback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxShowVisualFeedback.Location = new System.Drawing.Point(10, 33);
            this.chkBxShowVisualFeedback.Name = "chkBxShowVisualFeedback";
            this.chkBxShowVisualFeedback.Size = new System.Drawing.Size(105, 17);
            this.chkBxShowVisualFeedback.TabIndex = 9;
            this.chkBxShowVisualFeedback.Text = "Visual Feedback";
            this.chkBxShowVisualFeedback.UseVisualStyleBackColor = true;
            this.chkBxShowVisualFeedback.CheckedChanged += new System.EventHandler(this.chkBxShowVisualFeedback_CheckedChanged);
            // 
            // lblMenuMode
            // 
            this.lblMenuMode.AutoSize = true;
            this.lblMenuMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuMode.ForeColor = System.Drawing.Color.Gray;
            this.lblMenuMode.Location = new System.Drawing.Point(6, 82);
            this.lblMenuMode.Name = "lblMenuMode";
            this.lblMenuMode.Size = new System.Drawing.Size(122, 24);
            this.lblMenuMode.TabIndex = 10;
            this.lblMenuMode.Text = "Menu Mode";
            // 
            // lblUp
            // 
            this.lblUp.AutoSize = true;
            this.lblUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUp.ForeColor = System.Drawing.Color.Gray;
            this.lblUp.Location = new System.Drawing.Point(92, 124);
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(36, 24);
            this.lblUp.TabIndex = 11;
            this.lblUp.Text = "Up";
            // 
            // lblDown
            // 
            this.lblDown.AutoSize = true;
            this.lblDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDown.ForeColor = System.Drawing.Color.Gray;
            this.lblDown.Location = new System.Drawing.Point(6, 124);
            this.lblDown.Name = "lblDown";
            this.lblDown.Size = new System.Drawing.Size(63, 24);
            this.lblDown.TabIndex = 12;
            this.lblDown.Text = "Down";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.ForeColor = System.Drawing.Color.Gray;
            this.lblRight.Location = new System.Drawing.Point(264, 124);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(58, 24);
            this.lblRight.TabIndex = 13;
            this.lblRight.Text = "Right";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.ForeColor = System.Drawing.Color.Gray;
            this.lblLeft.Location = new System.Drawing.Point(178, 124);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(43, 24);
            this.lblLeft.TabIndex = 14;
            this.lblLeft.Text = "Left";
            // 
            // lblGuitarMode
            // 
            this.lblGuitarMode.AutoSize = true;
            this.lblGuitarMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuitarMode.ForeColor = System.Drawing.Color.Gray;
            this.lblGuitarMode.Location = new System.Drawing.Point(6, 247);
            this.lblGuitarMode.Name = "lblGuitarMode";
            this.lblGuitarMode.Size = new System.Drawing.Size(124, 24);
            this.lblGuitarMode.TabIndex = 15;
            this.lblGuitarMode.Text = "Guitar Mode";
            // 
            // lblEscape
            // 
            this.lblEscape.AutoSize = true;
            this.lblEscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscape.ForeColor = System.Drawing.Color.Gray;
            this.lblEscape.Location = new System.Drawing.Point(350, 124);
            this.lblEscape.Name = "lblEscape";
            this.lblEscape.Size = new System.Drawing.Size(55, 24);
            this.lblEscape.TabIndex = 16;
            this.lblEscape.Text = "Back";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.Gray;
            this.lblEnter.Location = new System.Drawing.Point(178, 182);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(60, 24);
            this.lblEnter.TabIndex = 17;
            this.lblEnter.Text = "Enter";
            // 
            // lblDataVolume
            // 
            this.lblDataVolume.AutoSize = true;
            this.lblDataVolume.Location = new System.Drawing.Point(737, 292);
            this.lblDataVolume.Name = "lblDataVolume";
            this.lblDataVolume.Size = new System.Drawing.Size(114, 13);
            this.lblDataVolume.TabIndex = 18;
            this.lblDataVolume.Text = "Data Received: 0 byte";
            // 
            // btnResetDataVolume
            // 
            this.btnResetDataVolume.Location = new System.Drawing.Point(914, 311);
            this.btnResetDataVolume.Name = "btnResetDataVolume";
            this.btnResetDataVolume.Size = new System.Drawing.Size(75, 23);
            this.btnResetDataVolume.TabIndex = 19;
            this.btnResetDataVolume.Text = "Reset";
            this.btnResetDataVolume.UseVisualStyleBackColor = true;
            this.btnResetDataVolume.Click += new System.EventHandler(this.btnResetDataVolume_Click);
            // 
            // lblKeyStrokeCount
            // 
            this.lblKeyStrokeCount.AutoSize = true;
            this.lblKeyStrokeCount.Location = new System.Drawing.Point(736, 307);
            this.lblKeyStrokeCount.Name = "lblKeyStrokeCount";
            this.lblKeyStrokeCount.Size = new System.Drawing.Size(73, 13);
            this.lblKeyStrokeCount.TabIndex = 20;
            this.lblKeyStrokeCount.Text = "KeyStrokes: 0";
            // 
            // picBxMeasureDelayGraph
            // 
            this.picBxMeasureDelayGraph.BackColor = System.Drawing.Color.Black;
            this.picBxMeasureDelayGraph.Location = new System.Drawing.Point(740, 356);
            this.picBxMeasureDelayGraph.Name = "picBxMeasureDelayGraph";
            this.picBxMeasureDelayGraph.Size = new System.Drawing.Size(249, 60);
            this.picBxMeasureDelayGraph.TabIndex = 21;
            this.picBxMeasureDelayGraph.TabStop = false;
            // 
            // lblMeasureDelayGraph
            // 
            this.lblMeasureDelayGraph.AutoSize = true;
            this.lblMeasureDelayGraph.Location = new System.Drawing.Point(737, 340);
            this.lblMeasureDelayGraph.Name = "lblMeasureDelayGraph";
            this.lblMeasureDelayGraph.Size = new System.Drawing.Size(129, 13);
            this.lblMeasureDelayGraph.TabIndex = 22;
            this.lblMeasureDelayGraph.Text = "CapSense measureDelay:";
            // 
            // lblMeasureDelayMin
            // 
            this.lblMeasureDelayMin.AutoSize = true;
            this.lblMeasureDelayMin.Location = new System.Drawing.Point(737, 423);
            this.lblMeasureDelayMin.Name = "lblMeasureDelayMin";
            this.lblMeasureDelayMin.Size = new System.Drawing.Size(36, 13);
            this.lblMeasureDelayMin.TabIndex = 23;
            this.lblMeasureDelayMin.Text = "Min: 0";
            // 
            // lblMeasureDelayMax
            // 
            this.lblMeasureDelayMax.AutoSize = true;
            this.lblMeasureDelayMax.Location = new System.Drawing.Point(925, 423);
            this.lblMeasureDelayMax.Name = "lblMeasureDelayMax";
            this.lblMeasureDelayMax.Size = new System.Drawing.Size(39, 13);
            this.lblMeasureDelayMax.TabIndex = 24;
            this.lblMeasureDelayMax.Text = "Max: 0";
            // 
            // grpBxVisualFeedBack
            // 
            this.grpBxVisualFeedBack.Controls.Add(this.lblMenuMode);
            this.grpBxVisualFeedBack.Controls.Add(this.lblFret1);
            this.grpBxVisualFeedBack.Controls.Add(this.lblFret2);
            this.grpBxVisualFeedBack.Controls.Add(this.lblFret3);
            this.grpBxVisualFeedBack.Controls.Add(this.lblFret4);
            this.grpBxVisualFeedBack.Controls.Add(this.lblFret5);
            this.grpBxVisualFeedBack.Controls.Add(this.lblPick);
            this.grpBxVisualFeedBack.Controls.Add(this.chkBxShowVisualFeedback);
            this.grpBxVisualFeedBack.Controls.Add(this.lblEnter);
            this.grpBxVisualFeedBack.Controls.Add(this.lblUp);
            this.grpBxVisualFeedBack.Controls.Add(this.lblEscape);
            this.grpBxVisualFeedBack.Controls.Add(this.lblDown);
            this.grpBxVisualFeedBack.Controls.Add(this.lblGuitarMode);
            this.grpBxVisualFeedBack.Controls.Add(this.lblRight);
            this.grpBxVisualFeedBack.Controls.Add(this.lblLeft);
            this.grpBxVisualFeedBack.Location = new System.Drawing.Point(316, 10);
            this.grpBxVisualFeedBack.Name = "grpBxVisualFeedBack";
            this.grpBxVisualFeedBack.Size = new System.Drawing.Size(415, 426);
            this.grpBxVisualFeedBack.TabIndex = 25;
            this.grpBxVisualFeedBack.TabStop = false;
            this.grpBxVisualFeedBack.Text = "Visual Feedback";
            // 
            // lstBxBTDevices
            // 
            this.lstBxBTDevices.FormattingEnabled = true;
            this.lstBxBTDevices.Location = new System.Drawing.Point(7, 104);
            this.lstBxBTDevices.Name = "lstBxBTDevices";
            this.lstBxBTDevices.Size = new System.Drawing.Size(152, 225);
            this.lstBxBTDevices.TabIndex = 26;
            // 
            // btnConnectBTDevice
            // 
            this.btnConnectBTDevice.Location = new System.Drawing.Point(165, 307);
            this.btnConnectBTDevice.Name = "btnConnectBTDevice";
            this.btnConnectBTDevice.Size = new System.Drawing.Size(113, 23);
            this.btnConnectBTDevice.TabIndex = 27;
            this.btnConnectBTDevice.Text = "Connect BT Device";
            this.btnConnectBTDevice.UseVisualStyleBackColor = true;
            this.btnConnectBTDevice.Click += new System.EventHandler(this.btnConnectBTDevice_Click);
            // 
            // btnSearchBTDevice
            // 
            this.btnSearchBTDevice.Location = new System.Drawing.Point(165, 278);
            this.btnSearchBTDevice.Name = "btnSearchBTDevice";
            this.btnSearchBTDevice.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBTDevice.TabIndex = 28;
            this.btnSearchBTDevice.Text = "Search";
            this.btnSearchBTDevice.UseVisualStyleBackColor = true;
            this.btnSearchBTDevice.Click += new System.EventHandler(this.btnSearchBTDevice_Click);
            // 
            // lblKeyStrokesPerSecond
            // 
            this.lblKeyStrokesPerSecond.AutoSize = true;
            this.lblKeyStrokesPerSecond.Location = new System.Drawing.Point(737, 327);
            this.lblKeyStrokesPerSecond.Name = "lblKeyStrokesPerSecond";
            this.lblKeyStrokesPerSecond.Size = new System.Drawing.Size(111, 13);
            this.lblKeyStrokesPerSecond.TabIndex = 29;
            this.lblKeyStrokesPerSecond.Text = "KeyStrokes per sec: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 449);
            this.Controls.Add(this.lblKeyStrokesPerSecond);
            this.Controls.Add(this.btnSearchBTDevice);
            this.Controls.Add(this.btnConnectBTDevice);
            this.Controls.Add(this.lstBxBTDevices);
            this.Controls.Add(this.grpBxVisualFeedBack);
            this.Controls.Add(this.lblMeasureDelayMax);
            this.Controls.Add(this.lblMeasureDelayMin);
            this.Controls.Add(this.lblMeasureDelayGraph);
            this.Controls.Add(this.picBxMeasureDelayGraph);
            this.Controls.Add(this.lblKeyStrokeCount);
            this.Controls.Add(this.btnResetDataVolume);
            this.Controls.Add(this.lblDataVolume);
            this.Controls.Add(this.lstBxReceived);
            this.Controls.Add(this.btnConnectComPort);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "FoFCustomControllerDriver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBxMeasureDelayGraph)).EndInit();
            this.grpBxVisualFeedBack.ResumeLayout(false);
            this.grpBxVisualFeedBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConnectComPort;
        private System.Windows.Forms.ListBox lstBxReceived;
        private System.Windows.Forms.Label lblFret1;
        private System.Windows.Forms.Label lblFret2;
        private System.Windows.Forms.Label lblFret3;
        private System.Windows.Forms.Label lblFret4;
        private System.Windows.Forms.Label lblFret5;
        private System.Windows.Forms.Label lblPick;
        private System.Windows.Forms.CheckBox chkBxShowVisualFeedback;
        private System.Windows.Forms.Label lblMenuMode;
        private System.Windows.Forms.Label lblUp;
        private System.Windows.Forms.Label lblDown;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblGuitarMode;
        private System.Windows.Forms.Label lblEscape;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblDataVolume;
        private System.Windows.Forms.Button btnResetDataVolume;
        private System.Windows.Forms.Label lblKeyStrokeCount;
        private System.Windows.Forms.PictureBox picBxMeasureDelayGraph;
        private System.Windows.Forms.Label lblMeasureDelayGraph;
        private System.Windows.Forms.Label lblMeasureDelayMin;
        private System.Windows.Forms.Label lblMeasureDelayMax;
        private System.Windows.Forms.GroupBox grpBxVisualFeedBack;
        private System.Windows.Forms.ListBox lstBxBTDevices;
        private System.Windows.Forms.Button btnConnectBTDevice;
        private System.Windows.Forms.Button btnSearchBTDevice;
        private System.Windows.Forms.Label lblKeyStrokesPerSecond;
    }
}

