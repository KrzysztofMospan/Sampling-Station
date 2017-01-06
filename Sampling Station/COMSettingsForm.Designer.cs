namespace Sampling_Station
{
    partial class COMSettingsForm
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
            this.InputMaskLabel = new System.Windows.Forms.Label();
            this.SeparatorLabel = new System.Windows.Forms.Label();
            this.InputMaskTextBox = new System.Windows.Forms.TextBox();
            this.SeparatorTextBox = new System.Windows.Forms.TextBox();
            this.PortNameComboBox = new System.Windows.Forms.ComboBox();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.BaudLabel = new System.Windows.Forms.Label();
            this.DTRCheckBox = new System.Windows.Forms.CheckBox();
            this.RTSCheckBox = new System.Windows.Forms.CheckBox();
            this.BaudTextBox = new System.Windows.Forms.TextBox();
            this.ParityLabel = new System.Windows.Forms.Label();
            this.ParityComboBox = new System.Windows.Forms.ComboBox();
            this.StopBitsLabel = new System.Windows.Forms.Label();
            this.StopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.TimeoutLabel = new System.Windows.Forms.Label();
            this.TimeoutTextBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputMaskLabel
            // 
            this.InputMaskLabel.AutoSize = true;
            this.InputMaskLabel.Location = new System.Drawing.Point(12, 9);
            this.InputMaskLabel.Name = "InputMaskLabel";
            this.InputMaskLabel.Size = new System.Drawing.Size(59, 13);
            this.InputMaskLabel.TabIndex = 0;
            this.InputMaskLabel.Text = "Input mask";
            // 
            // SeparatorLabel
            // 
            this.SeparatorLabel.AutoSize = true;
            this.SeparatorLabel.Location = new System.Drawing.Point(279, 9);
            this.SeparatorLabel.Name = "SeparatorLabel";
            this.SeparatorLabel.Size = new System.Drawing.Size(53, 13);
            this.SeparatorLabel.TabIndex = 1;
            this.SeparatorLabel.Text = "Separator";
            // 
            // InputMaskTextBox
            // 
            this.InputMaskTextBox.Location = new System.Drawing.Point(77, 6);
            this.InputMaskTextBox.Name = "InputMaskTextBox";
            this.InputMaskTextBox.Size = new System.Drawing.Size(196, 20);
            this.InputMaskTextBox.TabIndex = 2;
            // 
            // SeparatorTextBox
            // 
            this.SeparatorTextBox.Location = new System.Drawing.Point(338, 6);
            this.SeparatorTextBox.Name = "SeparatorTextBox";
            this.SeparatorTextBox.Size = new System.Drawing.Size(34, 20);
            this.SeparatorTextBox.TabIndex = 3;
            this.SeparatorTextBox.Text = ",";
            // 
            // PortNameComboBox
            // 
            this.PortNameComboBox.FormattingEnabled = true;
            this.PortNameComboBox.Location = new System.Drawing.Point(77, 32);
            this.PortNameComboBox.Name = "PortNameComboBox";
            this.PortNameComboBox.Size = new System.Drawing.Size(77, 21);
            this.PortNameComboBox.TabIndex = 4;
            this.PortNameComboBox.SelectedIndexChanged += new System.EventHandler(this.PortNameComboBox_SelectedIndexChanged);
            this.PortNameComboBox.DropDownClosed += new System.EventHandler(this.PortNameComboBox_DropDownClosed);
            this.PortNameComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PortNameComboBox_MouseClick);
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Location = new System.Drawing.Point(12, 35);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(55, 13);
            this.PortNameLabel.TabIndex = 5;
            this.PortNameLabel.Text = "Port name";
            // 
            // BaudLabel
            // 
            this.BaudLabel.AutoSize = true;
            this.BaudLabel.Location = new System.Drawing.Point(160, 35);
            this.BaudLabel.Name = "BaudLabel";
            this.BaudLabel.Size = new System.Drawing.Size(32, 13);
            this.BaudLabel.TabIndex = 6;
            this.BaudLabel.Text = "Baud";
            // 
            // DTRCheckBox
            // 
            this.DTRCheckBox.AutoSize = true;
            this.DTRCheckBox.Location = new System.Drawing.Point(313, 34);
            this.DTRCheckBox.Name = "DTRCheckBox";
            this.DTRCheckBox.Size = new System.Drawing.Size(49, 17);
            this.DTRCheckBox.TabIndex = 8;
            this.DTRCheckBox.Text = "DTR";
            this.DTRCheckBox.UseVisualStyleBackColor = true;
            // 
            // RTSCheckBox
            // 
            this.RTSCheckBox.AutoSize = true;
            this.RTSCheckBox.Location = new System.Drawing.Point(259, 34);
            this.RTSCheckBox.Name = "RTSCheckBox";
            this.RTSCheckBox.Size = new System.Drawing.Size(48, 17);
            this.RTSCheckBox.TabIndex = 9;
            this.RTSCheckBox.Text = "RTS";
            this.RTSCheckBox.UseVisualStyleBackColor = true;
            // 
            // BaudTextBox
            // 
            this.BaudTextBox.Location = new System.Drawing.Point(198, 32);
            this.BaudTextBox.Name = "BaudTextBox";
            this.BaudTextBox.Size = new System.Drawing.Size(55, 20);
            this.BaudTextBox.TabIndex = 10;
            this.BaudTextBox.Text = "9600";
            // 
            // ParityLabel
            // 
            this.ParityLabel.AutoSize = true;
            this.ParityLabel.Location = new System.Drawing.Point(12, 62);
            this.ParityLabel.Name = "ParityLabel";
            this.ParityLabel.Size = new System.Drawing.Size(33, 13);
            this.ParityLabel.TabIndex = 11;
            this.ParityLabel.Text = "Parity";
            // 
            // ParityComboBox
            // 
            this.ParityComboBox.FormattingEnabled = true;
            this.ParityComboBox.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.ParityComboBox.Location = new System.Drawing.Point(77, 59);
            this.ParityComboBox.Name = "ParityComboBox";
            this.ParityComboBox.Size = new System.Drawing.Size(62, 21);
            this.ParityComboBox.TabIndex = 12;
            this.ParityComboBox.Text = "None";
            // 
            // StopBitsLabel
            // 
            this.StopBitsLabel.AutoSize = true;
            this.StopBitsLabel.Location = new System.Drawing.Point(146, 62);
            this.StopBitsLabel.Name = "StopBitsLabel";
            this.StopBitsLabel.Size = new System.Drawing.Size(46, 13);
            this.StopBitsLabel.TabIndex = 13;
            this.StopBitsLabel.Text = "StopBits";
            // 
            // StopBitsComboBox
            // 
            this.StopBitsComboBox.FormattingEnabled = true;
            this.StopBitsComboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.StopBitsComboBox.Location = new System.Drawing.Point(198, 59);
            this.StopBitsComboBox.Name = "StopBitsComboBox";
            this.StopBitsComboBox.Size = new System.Drawing.Size(55, 21);
            this.StopBitsComboBox.TabIndex = 14;
            this.StopBitsComboBox.Text = "1";
            // 
            // TimeoutLabel
            // 
            this.TimeoutLabel.AutoSize = true;
            this.TimeoutLabel.Location = new System.Drawing.Point(259, 62);
            this.TimeoutLabel.Name = "TimeoutLabel";
            this.TimeoutLabel.Size = new System.Drawing.Size(45, 13);
            this.TimeoutLabel.TabIndex = 15;
            this.TimeoutLabel.Text = "Timeout";
            // 
            // TimeoutTextBox
            // 
            this.TimeoutTextBox.Location = new System.Drawing.Point(310, 60);
            this.TimeoutTextBox.Name = "TimeoutTextBox";
            this.TimeoutTextBox.Size = new System.Drawing.Size(62, 20);
            this.TimeoutTextBox.TabIndex = 16;
            this.TimeoutTextBox.Text = "0";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(12, 86);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(214, 23);
            this.ApplyButton.TabIndex = 17;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(232, 86);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(130, 23);
            this.CancelButton.TabIndex = 18;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // COMSettingsWindows
            // 
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 113);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.TimeoutTextBox);
            this.Controls.Add(this.TimeoutLabel);
            this.Controls.Add(this.StopBitsComboBox);
            this.Controls.Add(this.StopBitsLabel);
            this.Controls.Add(this.ParityComboBox);
            this.Controls.Add(this.ParityLabel);
            this.Controls.Add(this.BaudTextBox);
            this.Controls.Add(this.RTSCheckBox);
            this.Controls.Add(this.DTRCheckBox);
            this.Controls.Add(this.BaudLabel);
            this.Controls.Add(this.PortNameLabel);
            this.Controls.Add(this.PortNameComboBox);
            this.Controls.Add(this.SeparatorTextBox);
            this.Controls.Add(this.InputMaskTextBox);
            this.Controls.Add(this.SeparatorLabel);
            this.Controls.Add(this.InputMaskLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "COMSettingsWindows";
            this.Text = "Settings for COM connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputMaskLabel;
        private System.Windows.Forms.Label SeparatorLabel;
        private System.Windows.Forms.TextBox InputMaskTextBox;
        private System.Windows.Forms.TextBox SeparatorTextBox;
        private System.Windows.Forms.ComboBox PortNameComboBox;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.Label BaudLabel;
        private System.Windows.Forms.CheckBox DTRCheckBox;
        private System.Windows.Forms.CheckBox RTSCheckBox;
        private System.Windows.Forms.TextBox BaudTextBox;
        private System.Windows.Forms.Label ParityLabel;
        private System.Windows.Forms.ComboBox ParityComboBox;
        private System.Windows.Forms.Label StopBitsLabel;
        private System.Windows.Forms.ComboBox StopBitsComboBox;
        private System.Windows.Forms.Label TimeoutLabel;
        private System.Windows.Forms.TextBox TimeoutTextBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelButton;
    }
}