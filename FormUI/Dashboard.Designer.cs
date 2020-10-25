namespace FormUI
{
    partial class Dashboard
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
            this.lstSessionsFound = new System.Windows.Forms.ListBox();
            this.txtDateQuery = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS_1_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtS_1_2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtS_1_3 = new System.Windows.Forms.TextBox();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtS_2_3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtS_2_2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtS_2_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstSessionsFound
            // 
            this.lstSessionsFound.FormattingEnabled = true;
            this.lstSessionsFound.Location = new System.Drawing.Point(78, 73);
            this.lstSessionsFound.Name = "lstSessionsFound";
            this.lstSessionsFound.Size = new System.Drawing.Size(346, 95);
            this.lstSessionsFound.TabIndex = 0;
            // 
            // txtDateQuery
            // 
            this.txtDateQuery.Location = new System.Drawing.Point(176, 26);
            this.txtDateQuery.Name = "txtDateQuery";
            this.txtDateQuery.Size = new System.Drawing.Size(100, 20);
            this.txtDateQuery.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(75, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(87, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date (yyyy-mm-tt)";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(349, 44);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // txtDateDisplay
            // 
            this.txtDateDisplay.Location = new System.Drawing.Point(156, 192);
            this.txtDateDisplay.Name = "txtDateDisplay";
            this.txtDateDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtDateDisplay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Session 1/1";
            // 
            // txtS_1_1
            // 
            this.txtS_1_1.Location = new System.Drawing.Point(156, 230);
            this.txtS_1_1.Name = "txtS_1_1";
            this.txtS_1_1.Size = new System.Drawing.Size(100, 20);
            this.txtS_1_1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Session 1/2";
            // 
            // txtS_1_2
            // 
            this.txtS_1_2.Location = new System.Drawing.Point(156, 256);
            this.txtS_1_2.Name = "txtS_1_2";
            this.txtS_1_2.Size = new System.Drawing.Size(100, 20);
            this.txtS_1_2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Session 1/3";
            // 
            // txtS_1_3
            // 
            this.txtS_1_3.Location = new System.Drawing.Point(156, 282);
            this.txtS_1_3.Name = "txtS_1_3";
            this.txtS_1_3.Size = new System.Drawing.Size(100, 20);
            this.txtS_1_3.TabIndex = 10;
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(334, 337);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(75, 23);
            this.insertRecordButton.TabIndex = 12;
            this.insertRecordButton.Text = "Insert record";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Session 2/3";
            // 
            // txtS_2_3
            // 
            this.txtS_2_3.Location = new System.Drawing.Point(156, 379);
            this.txtS_2_3.Name = "txtS_2_3";
            this.txtS_2_3.Size = new System.Drawing.Size(100, 20);
            this.txtS_2_3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Session 2/2";
            // 
            // txtS_2_2
            // 
            this.txtS_2_2.Location = new System.Drawing.Point(156, 353);
            this.txtS_2_2.Name = "txtS_2_2";
            this.txtS_2_2.Size = new System.Drawing.Size(100, 20);
            this.txtS_2_2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Session 2/1";
            // 
            // txtS_2_1
            // 
            this.txtS_2_1.Location = new System.Drawing.Point(156, 327);
            this.txtS_2_1.Name = "txtS_2_1";
            this.txtS_2_1.Size = new System.Drawing.Size(100, 20);
            this.txtS_2_1.TabIndex = 13;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtS_2_3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtS_2_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtS_2_1);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtS_1_3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtS_1_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtS_1_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDateDisplay);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDateQuery);
            this.Controls.Add(this.lstSessionsFound);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSessionsFound;
        private System.Windows.Forms.TextBox txtDateQuery;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS_1_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtS_1_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtS_1_3;
        private System.Windows.Forms.Button insertRecordButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtS_2_3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtS_2_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtS_2_1;
    }
}

