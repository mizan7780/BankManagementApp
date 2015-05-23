namespace FastBankingManagementApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customerAccountOpeningDateTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailEntryTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.customerNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.amountDeposit_Button = new System.Windows.Forms.Button();
            this.amountForTransactionTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberForTransactionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AccountlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.customerAccountOpeningDateTextBox);
            this.groupBox1.Controls.Add(this.customerEmailEntryTextBox);
            this.groupBox1.Controls.Add(this.accountNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.customerNameEntryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer And Account Information Entry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.accountSave_Button);
            // 
            // customerAccountOpeningDateTextBox
            // 
            this.customerAccountOpeningDateTextBox.Location = new System.Drawing.Point(104, 121);
            this.customerAccountOpeningDateTextBox.Name = "customerAccountOpeningDateTextBox";
            this.customerAccountOpeningDateTextBox.Size = new System.Drawing.Size(146, 20);
            this.customerAccountOpeningDateTextBox.TabIndex = 4;
            // 
            // customerEmailEntryTextBox
            // 
            this.customerEmailEntryTextBox.Location = new System.Drawing.Point(104, 86);
            this.customerEmailEntryTextBox.Name = "customerEmailEntryTextBox";
            this.customerEmailEntryTextBox.Size = new System.Drawing.Size(146, 20);
            this.customerEmailEntryTextBox.TabIndex = 4;
            // 
            // accountNumberEntryTextBox
            // 
            this.accountNumberEntryTextBox.Location = new System.Drawing.Point(104, 57);
            this.accountNumberEntryTextBox.Name = "accountNumberEntryTextBox";
            this.accountNumberEntryTextBox.Size = new System.Drawing.Size(146, 20);
            this.accountNumberEntryTextBox.TabIndex = 4;
            // 
            // customerNameEntryTextBox
            // 
            this.customerNameEntryTextBox.Location = new System.Drawing.Point(105, 26);
            this.customerNameEntryTextBox.Name = "customerNameEntryTextBox";
            this.customerNameEntryTextBox.Size = new System.Drawing.Size(146, 20);
            this.customerNameEntryTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opening Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.amountDeposit_Button);
            this.groupBox2.Controls.Add(this.amountForTransactionTextBox);
            this.groupBox2.Controls.Add(this.accountNumberForTransactionTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(331, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Withdraw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.amountWithdraw_Button);
            // 
            // amountDeposit_Button
            // 
            this.amountDeposit_Button.Location = new System.Drawing.Point(107, 90);
            this.amountDeposit_Button.Name = "amountDeposit_Button";
            this.amountDeposit_Button.Size = new System.Drawing.Size(75, 23);
            this.amountDeposit_Button.TabIndex = 3;
            this.amountDeposit_Button.Text = "Deposit";
            this.amountDeposit_Button.UseVisualStyleBackColor = true;
            this.amountDeposit_Button.Click += new System.EventHandler(this.amountDeposit_Button_Click);
            // 
            // amountForTransactionTextBox
            // 
            this.amountForTransactionTextBox.Location = new System.Drawing.Point(107, 57);
            this.amountForTransactionTextBox.Name = "amountForTransactionTextBox";
            this.amountForTransactionTextBox.Size = new System.Drawing.Size(157, 20);
            this.amountForTransactionTextBox.TabIndex = 2;
            // 
            // accountNumberForTransactionTextBox
            // 
            this.accountNumberForTransactionTextBox.Location = new System.Drawing.Point(107, 29);
            this.accountNumberForTransactionTextBox.Name = "accountNumberForTransactionTextBox";
            this.accountNumberForTransactionTextBox.Size = new System.Drawing.Size(157, 20);
            this.accountNumberForTransactionTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AccountlistView);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.SearchTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(13, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer And Account Information";
            // 
            // AccountlistView
            // 
            this.AccountlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.AccountlistView.GridLines = true;
            this.AccountlistView.Location = new System.Drawing.Point(6, 45);
            this.AccountlistView.Name = "AccountlistView";
            this.AccountlistView.Size = new System.Drawing.Size(576, 165);
            this.AccountlistView.TabIndex = 3;
            this.AccountlistView.UseCompatibleStateImageBehavior = false;
            this.AccountlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Account Number";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Customer Name";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Opening Date";
            this.columnHeader3.Width = 163;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Balance";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Search_Button);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(357, 18);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(143, 20);
            this.SearchTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Papyrus", 19.5F);
            this.label8.Location = new System.Drawing.Point(327, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 41);
            this.label8.TabIndex = 3;
            this.label8.Text = "Fast Banking Solution";
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 446);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Customer And Account Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox customerAccountOpeningDateTextBox;
        private System.Windows.Forms.TextBox customerEmailEntryTextBox;
        private System.Windows.Forms.TextBox accountNumberEntryTextBox;
        private System.Windows.Forms.TextBox customerNameEntryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button amountDeposit_Button;
        private System.Windows.Forms.TextBox amountForTransactionTextBox;
        private System.Windows.Forms.TextBox accountNumberForTransactionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView AccountlistView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

