﻿namespace testClassLib
{
    partial class calendarFrm
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
            this.countryLstBx = new System.Windows.Forms.ListBox();
            this.selectedCountryLstBx = new System.Windows.Forms.ListBox();
            this.indicatorLstBx = new System.Windows.Forms.ListBox();
            this.selectedIndicatorLstBx = new System.Windows.Forms.ListBox();
            this.btnCntryAdd = new System.Windows.Forms.Button();
            this.btnCntryRemove = new System.Windows.Forms.Button();
            this.btnIndctrAdd = new System.Windows.Forms.Button();
            this.btnIndctrRemove = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cntryTextBox = new System.Windows.Forms.TextBox();
            this.indctrTextBox = new System.Windows.Forms.TextBox();
            this.activeCellPositionBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.allIndicatorsBox = new System.Windows.Forms.CheckBox();
            this.allCountriesBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.columnsListBox = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // countryLstBx
            // 
            this.countryLstBx.AllowDrop = true;
            this.countryLstBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLstBx.FormattingEnabled = true;
            this.countryLstBx.ItemHeight = 16;
            this.countryLstBx.Location = new System.Drawing.Point(7, 52);
            this.countryLstBx.Name = "countryLstBx";
            this.countryLstBx.ScrollAlwaysVisible = true;
            this.countryLstBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.countryLstBx.Size = new System.Drawing.Size(214, 144);
            this.countryLstBx.TabIndex = 0;
            // 
            // selectedCountryLstBx
            // 
            this.selectedCountryLstBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedCountryLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCountryLstBx.FormattingEnabled = true;
            this.selectedCountryLstBx.ItemHeight = 16;
            this.selectedCountryLstBx.Location = new System.Drawing.Point(336, 52);
            this.selectedCountryLstBx.Name = "selectedCountryLstBx";
            this.selectedCountryLstBx.ScrollAlwaysVisible = true;
            this.selectedCountryLstBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectedCountryLstBx.Size = new System.Drawing.Size(214, 144);
            this.selectedCountryLstBx.Sorted = true;
            this.selectedCountryLstBx.TabIndex = 1;
            // 
            // indicatorLstBx
            // 
            this.indicatorLstBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indicatorLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicatorLstBx.FormattingEnabled = true;
            this.indicatorLstBx.ItemHeight = 16;
            this.indicatorLstBx.Location = new System.Drawing.Point(7, 278);
            this.indicatorLstBx.Name = "indicatorLstBx";
            this.indicatorLstBx.ScrollAlwaysVisible = true;
            this.indicatorLstBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.indicatorLstBx.Size = new System.Drawing.Size(214, 144);
            this.indicatorLstBx.Sorted = true;
            this.indicatorLstBx.TabIndex = 2;
            // 
            // selectedIndicatorLstBx
            // 
            this.selectedIndicatorLstBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedIndicatorLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedIndicatorLstBx.FormattingEnabled = true;
            this.selectedIndicatorLstBx.ItemHeight = 16;
            this.selectedIndicatorLstBx.Location = new System.Drawing.Point(336, 278);
            this.selectedIndicatorLstBx.Name = "selectedIndicatorLstBx";
            this.selectedIndicatorLstBx.ScrollAlwaysVisible = true;
            this.selectedIndicatorLstBx.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectedIndicatorLstBx.Size = new System.Drawing.Size(214, 144);
            this.selectedIndicatorLstBx.Sorted = true;
            this.selectedIndicatorLstBx.TabIndex = 3;
            // 
            // btnCntryAdd
            // 
            this.btnCntryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCntryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCntryAdd.Location = new System.Drawing.Point(229, 93);
            this.btnCntryAdd.Name = "btnCntryAdd";
            this.btnCntryAdd.Size = new System.Drawing.Size(99, 31);
            this.btnCntryAdd.TabIndex = 4;
            this.btnCntryAdd.Text = "-->";
            this.btnCntryAdd.UseVisualStyleBackColor = true;
            this.btnCntryAdd.Click += new System.EventHandler(this.btnCntryAdd_Click);
            // 
            // btnCntryRemove
            // 
            this.btnCntryRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCntryRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCntryRemove.Location = new System.Drawing.Point(229, 131);
            this.btnCntryRemove.Name = "btnCntryRemove";
            this.btnCntryRemove.Size = new System.Drawing.Size(99, 31);
            this.btnCntryRemove.TabIndex = 5;
            this.btnCntryRemove.Text = "<--";
            this.btnCntryRemove.UseVisualStyleBackColor = true;
            this.btnCntryRemove.Click += new System.EventHandler(this.btnCntryRemove_Click);
            // 
            // btnIndctrAdd
            // 
            this.btnIndctrAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndctrAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndctrAdd.Location = new System.Drawing.Point(229, 316);
            this.btnIndctrAdd.Name = "btnIndctrAdd";
            this.btnIndctrAdd.Size = new System.Drawing.Size(99, 31);
            this.btnIndctrAdd.TabIndex = 6;
            this.btnIndctrAdd.Text = "-->";
            this.btnIndctrAdd.UseVisualStyleBackColor = true;
            this.btnIndctrAdd.Click += new System.EventHandler(this.btnIndctrAdd_Click);
            // 
            // btnIndctrRemove
            // 
            this.btnIndctrRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndctrRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndctrRemove.Location = new System.Drawing.Point(229, 355);
            this.btnIndctrRemove.Name = "btnIndctrRemove";
            this.btnIndctrRemove.Size = new System.Drawing.Size(99, 31);
            this.btnIndctrRemove.TabIndex = 7;
            this.btnIndctrRemove.Text = "<--";
            this.btnIndctrRemove.UseVisualStyleBackColor = true;
            this.btnIndctrRemove.Click += new System.EventHandler(this.btnIndctrRemove_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(355, 506);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 31);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(469, 506);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(350, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 22);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Countries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selected Countries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Indicators";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Selected Indicators";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Start Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "End Data";
            // 
            // cntryTextBox
            // 
            this.cntryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cntryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntryTextBox.Location = new System.Drawing.Point(7, 33);
            this.cntryTextBox.Name = "cntryTextBox";
            this.cntryTextBox.AutoSize = false;
            this.cntryTextBox.Size = new System.Drawing.Size(214, 16);
            this.cntryTextBox.TabIndex = 18;
            this.cntryTextBox.TextChanged += new System.EventHandler(this.cntryTextBox_TextChanged);
            // 
            // indctrTextBox
            // 
            this.indctrTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indctrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indctrTextBox.Location = new System.Drawing.Point(7, 259);
            this.indctrTextBox.Name = "indctrTextBox";
            this.indctrTextBox.AutoSize = false;
            this.indctrTextBox.Size = new System.Drawing.Size(214, 16);
            this.indctrTextBox.TabIndex = 19;
            this.indctrTextBox.TextChanged += new System.EventHandler(this.indctrTextBox_TextChanged);
            // 
            // activeCellPositionBox
            // 
            this.activeCellPositionBox.Location = new System.Drawing.Point(350, 137);
            this.activeCellPositionBox.Name = "activeCellPositionBox";
            this.activeCellPositionBox.Size = new System.Drawing.Size(141, 22);
            this.activeCellPositionBox.TabIndex = 20;
            this.activeCellPositionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Formula Cell";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 493);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.allIndicatorsBox);
            this.tabPage1.Controls.Add(this.allCountriesBox);
            this.tabPage1.Controls.Add(this.indicatorLstBx);
            this.tabPage1.Controls.Add(this.countryLstBx);
            this.tabPage1.Controls.Add(this.selectedCountryLstBx);
            this.tabPage1.Controls.Add(this.indctrTextBox);
            this.tabPage1.Controls.Add(this.selectedIndicatorLstBx);
            this.tabPage1.Controls.Add(this.cntryTextBox);
            this.tabPage1.Controls.Add(this.btnCntryAdd);
            this.tabPage1.Controls.Add(this.btnCntryRemove);
            this.tabPage1.Controls.Add(this.btnIndctrAdd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnIndctrRemove);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            // 
            // allIndicatorsBox
            // 
            this.allIndicatorsBox.AutoSize = true;
            this.allIndicatorsBox.Location = new System.Drawing.Point(7, 428);
            this.allIndicatorsBox.Name = "allIndicatorsBox";
            this.allIndicatorsBox.Size = new System.Drawing.Size(103, 20);
            this.allIndicatorsBox.TabIndex = 21;
            this.allIndicatorsBox.Text = "All indicators";
            this.allIndicatorsBox.UseVisualStyleBackColor = true;
            this.allIndicatorsBox.CheckedChanged += new System.EventHandler(this.allIndicatorsBox_CheckedChanged);
            // 
            // allCountriesBox
            // 
            this.allCountriesBox.AutoSize = true;
            this.allCountriesBox.Location = new System.Drawing.Point(7, 202);
            this.allCountriesBox.Name = "allCountriesBox";
            this.allCountriesBox.Size = new System.Drawing.Size(99, 20);
            this.allCountriesBox.TabIndex = 20;
            this.allCountriesBox.Text = "All countries";
            this.allCountriesBox.UseVisualStyleBackColor = true;
            this.allCountriesBox.CheckedChanged += new System.EventHandler(this.allCountriesBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.columnsListBox);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.activeCellPositionBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Selected Columns";
            // 
            // columnsListBox
            // 
            this.columnsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.columnsListBox.CheckOnClick = true;
            this.columnsListBox.FormattingEnabled = true;
            this.columnsListBox.Location = new System.Drawing.Point(6, 29);
            this.columnsListBox.Name = "columnsListBox";
            this.columnsListBox.Size = new System.Drawing.Size(188, 289);
            this.columnsListBox.TabIndex = 22;
            // 
            // calendarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 553);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "calendarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox countryLstBx;
        private System.Windows.Forms.ListBox selectedCountryLstBx;
        private System.Windows.Forms.ListBox indicatorLstBx;
        private System.Windows.Forms.ListBox selectedIndicatorLstBx;
        private System.Windows.Forms.Button btnCntryAdd;
        private System.Windows.Forms.Button btnCntryRemove;
        private System.Windows.Forms.Button btnIndctrAdd;
        private System.Windows.Forms.Button btnIndctrRemove;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cntryTextBox;
        private System.Windows.Forms.TextBox indctrTextBox;
        private System.Windows.Forms.TextBox activeCellPositionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox columnsListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox allCountriesBox;
        private System.Windows.Forms.CheckBox allIndicatorsBox;
    }
}