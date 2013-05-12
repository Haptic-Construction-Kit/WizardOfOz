namespace WizardOfOz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputComPort = new System.Windows.Forms.ComboBox();
            this.outputComPort = new System.Windows.Forms.ComboBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.stopRecordButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputComPort
            // 
            this.inputComPort.FormattingEnabled = true;
            this.inputComPort.Location = new System.Drawing.Point(12, 12);
            this.inputComPort.Name = "inputComPort";
            this.inputComPort.Size = new System.Drawing.Size(121, 21);
            this.inputComPort.TabIndex = 0;
            // 
            // outputComPort
            // 
            this.outputComPort.FormattingEnabled = true;
            this.outputComPort.Location = new System.Drawing.Point(12, 42);
            this.outputComPort.Name = "outputComPort";
            this.outputComPort.Size = new System.Drawing.Size(121, 21);
            this.outputComPort.TabIndex = 1;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(141, 20);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(80, 13);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Input COM Port";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(141, 48);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(88, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "Output COM Port";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(13, 69);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(121, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(140, 68);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(121, 24);
            this.disconnectButton.TabIndex = 5;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lean Forward";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(139, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Lean Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(12, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 63);
            this.button3.TabIndex = 8;
            this.button3.Text = "Head Nod";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(139, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 63);
            this.button4.TabIndex = 9;
            this.button4.Text = "Head Shake";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(13, 98);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(121, 23);
            this.recordButton.TabIndex = 10;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // stopRecordButton
            // 
            this.stopRecordButton.Location = new System.Drawing.Point(139, 98);
            this.stopRecordButton.Name = "stopRecordButton";
            this.stopRecordButton.Size = new System.Drawing.Size(121, 23);
            this.stopRecordButton.TabIndex = 11;
            this.stopRecordButton.Text = "Stop Recording";
            this.stopRecordButton.UseVisualStyleBackColor = true;
            this.stopRecordButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(33, 262);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(196, 20);
            this.display.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 294);
            this.Controls.Add(this.display);
            this.Controls.Add(this.stopRecordButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.outputComPort);
            this.Controls.Add(this.inputComPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputComPort;
        private System.Windows.Forms.ComboBox outputComPort;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button stopRecordButton;
        private System.Windows.Forms.TextBox display;

    }
}

