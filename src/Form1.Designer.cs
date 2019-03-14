namespace Formatter
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
            this.OKButton = new System.Windows.Forms.Button();
            this.FormatStrings = new System.Windows.Forms.ComboBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.RadioButton();
            this.NumberBox = new System.Windows.Forms.RadioButton();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.CultureNames = new System.Windows.Forms.ComboBox();
            this.CulturesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Result = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.chkContinuous = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(373, 227);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(41, 23);
            this.OKButton.TabIndex = 17;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FormatStrings
            // 
            this.FormatStrings.FormattingEnabled = true;
            this.FormatStrings.Location = new System.Drawing.Point(17, 25);
            this.FormatStrings.Name = "FormatStrings";
            this.FormatStrings.Size = new System.Drawing.Size(192, 21);
            this.FormatStrings.TabIndex = 14;
            this.FormatStrings.SelectedIndexChanged += new System.EventHandler(this.FormatStrings_SelectedIndexChanged);
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(14, 9);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(90, 13);
            this.FormatLabel.TabIndex = 13;
            this.FormatLabel.Text = "FormatComboBox";
            // 
            // DateBox
            // 
            this.DateBox.AutoSize = true;
            this.DateBox.Location = new System.Drawing.Point(281, 42);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(90, 17);
            this.DateBox.TabIndex = 12;
            this.DateBox.TabStop = true;
            this.DateBox.Text = "RadioButton2";
            this.DateBox.UseVisualStyleBackColor = true;
            this.DateBox.CheckedChanged += new System.EventHandler(this.DateBox_CheckedChanged);
            // 
            // NumberBox
            // 
            this.NumberBox.AutoSize = true;
            this.NumberBox.Location = new System.Drawing.Point(281, 18);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(90, 17);
            this.NumberBox.TabIndex = 11;
            this.NumberBox.TabStop = true;
            this.NumberBox.Text = "RadioButton1";
            this.NumberBox.UseVisualStyleBackColor = true;
            this.NumberBox.CheckedChanged += new System.EventHandler(this.NumberBox_CheckedChanged);
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 253);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(426, 22);
            this.StatusBar.TabIndex = 18;
            this.StatusBar.Text = "StatusStrip1";
            // 
            // CultureNames
            // 
            this.CultureNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CultureNames.FormattingEnabled = true;
            this.CultureNames.Location = new System.Drawing.Point(17, 75);
            this.CultureNames.Name = "CultureNames";
            this.CultureNames.Size = new System.Drawing.Size(192, 21);
            this.CultureNames.TabIndex = 20;
            this.CultureNames.SelectedIndexChanged += new System.EventHandler(this.CultureNames_SelectedIndexChanged);
            // 
            // CulturesLabel
            // 
            this.CulturesLabel.AutoSize = true;
            this.CulturesLabel.Location = new System.Drawing.Point(14, 59);
            this.CulturesLabel.Name = "CulturesLabel";
            this.CulturesLabel.Size = new System.Drawing.Size(91, 13);
            this.CulturesLabel.TabIndex = 19;
            this.CulturesLabel.Text = "CultureComboBox";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Result, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ValueLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResultLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 148);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // Result
            // 
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result.Location = new System.Drawing.Point(3, 97);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(344, 48);
            this.Result.TabIndex = 18;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(3, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(73, 13);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "ValueTextBox";
            // 
            // txtInput
            // 
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(3, 23);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(344, 48);
            this.txtInput.TabIndex = 11;
            this.txtInput.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(3, 74);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(76, 13);
            this.ResultLabel.TabIndex = 17;
            this.ResultLabel.Text = "ResultTextBox";
            // 
            // chkContinuous
            // 
            this.chkContinuous.AutoSize = true;
            this.chkContinuous.Location = new System.Drawing.Point(281, 66);
            this.chkContinuous.Name = "chkContinuous";
            this.chkContinuous.Size = new System.Drawing.Size(79, 17);
            this.chkContinuous.TabIndex = 22;
            this.chkContinuous.Text = "Continuous";
            this.chkContinuous.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 275);
            this.Controls.Add(this.chkContinuous);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CultureNames);
            this.Controls.Add(this.CulturesLabel);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.FormatStrings);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.NumberBox);
            this.Name = "Form1";
            this.Text = "Format test util";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Button OKButton;
      internal System.Windows.Forms.ComboBox FormatStrings;
      internal System.Windows.Forms.Label FormatLabel;
      internal System.Windows.Forms.RadioButton DateBox;
      internal System.Windows.Forms.RadioButton NumberBox;
      internal System.Windows.Forms.StatusStrip StatusBar;
      internal System.Windows.Forms.ComboBox CultureNames;
      internal System.Windows.Forms.Label CulturesLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.TextBox Result;
        internal System.Windows.Forms.Label ValueLabel;
        internal System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.CheckBox chkContinuous;
    }
}

