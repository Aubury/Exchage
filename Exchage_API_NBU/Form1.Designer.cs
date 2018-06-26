namespace Exchage
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
            this.label1 = new System.Windows.Forms.Label();
            this.usd_exchange = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.evro_exchange = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_To_buy = new System.Windows.Forms.TextBox();
            this.IN = new System.Windows.Forms.Label();
            this.comboBox_IN = new System.Windows.Forms.ComboBox();
            this.Change = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rub_exchange = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMailAddress = new System.Windows.Forms.TextBox();
            this.mailaddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "USD: ";
            // 
            // usd_exchange
            // 
            this.usd_exchange.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.usd_exchange.AutoSize = true;
            this.usd_exchange.Location = new System.Drawing.Point(66, 27);
            this.usd_exchange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usd_exchange.Name = "usd_exchange";
            this.usd_exchange.Size = new System.Drawing.Size(77, 13);
            this.usd_exchange.TabIndex = 2;
            this.usd_exchange.Text = "usd_exchange";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "EUR:";
            // 
            // evro_exchange
            // 
            this.evro_exchange.AutoSize = true;
            this.evro_exchange.Location = new System.Drawing.Point(66, 52);
            this.evro_exchange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.evro_exchange.Name = "evro_exchange";
            this.evro_exchange.Size = new System.Drawing.Size(81, 13);
            this.evro_exchange.TabIndex = 4;
            this.evro_exchange.Text = "evro_exchange";
            // 
            // Buy
            // 
            this.Buy.FormattingEnabled = true;
            this.Buy.Location = new System.Drawing.Point(18, 128);
            this.Buy.Margin = new System.Windows.Forms.Padding(2);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(82, 21);
            this.Buy.TabIndex = 5;
         
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "BUY";
            // 
            // amount_To_buy
            // 
            this.amount_To_buy.Location = new System.Drawing.Point(124, 129);
            this.amount_To_buy.Margin = new System.Windows.Forms.Padding(2);
            this.amount_To_buy.Name = "amount_To_buy";
            this.amount_To_buy.Size = new System.Drawing.Size(92, 20);
            this.amount_To_buy.TabIndex = 7;
            
            // 
            // IN
            // 
            this.IN.AutoSize = true;
            this.IN.Location = new System.Drawing.Point(18, 154);
            this.IN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(18, 13);
            this.IN.TabIndex = 8;
            this.IN.Text = "IN";
            // 
            // comboBox_IN
            // 
            this.comboBox_IN.FormattingEnabled = true;
            this.comboBox_IN.Location = new System.Drawing.Point(19, 177);
            this.comboBox_IN.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_IN.Name = "comboBox_IN";
            this.comboBox_IN.Size = new System.Drawing.Size(81, 21);
            this.comboBox_IN.TabIndex = 9;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(123, 162);
            this.Change.Margin = new System.Windows.Forms.Padding(2);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(92, 36);
            this.Change.TabIndex = 11;
            this.Change.Text = "CHANGE";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(18, 280);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 96);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "RUB:";
            // 
            // rub_exchange
            // 
            this.rub_exchange.AutoSize = true;
            this.rub_exchange.Location = new System.Drawing.Point(66, 76);
            this.rub_exchange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rub_exchange.Name = "rub_exchange";
            this.rub_exchange.Size = new System.Drawing.Size(75, 13);
            this.rub_exchange.TabIndex = 15;
            this.rub_exchange.Text = "rub_exchange";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "amount:";
            
            // 
            // textBoxMailAddress
            // 
            this.textBoxMailAddress.Location = new System.Drawing.Point(18, 237);
            this.textBoxMailAddress.Name = "textBoxMailAddress";
            this.textBoxMailAddress.Size = new System.Drawing.Size(197, 20);
            this.textBoxMailAddress.TabIndex = 17;
            // 
            // mailaddress
            // 
            this.mailaddress.AutoSize = true;
            this.mailaddress.Location = new System.Drawing.Point(22, 224);
            this.mailaddress.Name = "mailaddress";
            this.mailaddress.Size = new System.Drawing.Size(64, 13);
            this.mailaddress.TabIndex = 18;
            this.mailaddress.Text = "MailAddress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 400);
            this.Controls.Add(this.mailaddress);
            this.Controls.Add(this.textBoxMailAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rub_exchange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.comboBox_IN);
            this.Controls.Add(this.IN);
            this.Controls.Add(this.amount_To_buy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.evro_exchange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usd_exchange);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Exchange_Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usd_exchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label evro_exchange;
        private System.Windows.Forms.ComboBox Buy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount_To_buy;
        private System.Windows.Forms.Label IN;
        private System.Windows.Forms.ComboBox comboBox_IN;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rub_exchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMailAddress;
        private System.Windows.Forms.Label mailaddress;
    }
}

