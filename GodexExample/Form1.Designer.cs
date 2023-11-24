namespace GodexExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrinterFindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.printername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dayoftimetextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productnametextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qrcodetextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PrinterFindButton
            // 
            this.PrinterFindButton.AutoSize = true;
            this.PrinterFindButton.Location = new System.Drawing.Point(12, 244);
            this.PrinterFindButton.Name = "PrinterFindButton";
            this.PrinterFindButton.Size = new System.Drawing.Size(432, 39);
            this.PrinterFindButton.TabIndex = 0;
            this.PrinterFindButton.Text = "Print Label";
            this.PrinterFindButton.UseVisualStyleBackColor = true;
            this.PrinterFindButton.Click += new System.EventHandler(this.PrinterFindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Printer List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 154);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // printername
            // 
            this.printername.Location = new System.Drawing.Point(117, 205);
            this.printername.Name = "printername";
            this.printername.Size = new System.Drawing.Size(100, 23);
            this.printername.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Printer Name";
            // 
            // dayoftimetextbox
            // 
            this.dayoftimetextbox.Location = new System.Drawing.Point(327, 41);
            this.dayoftimetextbox.Name = "dayoftimetextbox";
            this.dayoftimetextbox.Size = new System.Drawing.Size(117, 23);
            this.dayoftimetextbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product Name";
            // 
            // productnametextbox
            // 
            this.productnametextbox.Location = new System.Drawing.Point(327, 70);
            this.productnametextbox.Name = "productnametextbox";
            this.productnametextbox.Size = new System.Drawing.Size(117, 23);
            this.productnametextbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "QR Code";
            // 
            // qrcodetextbox
            // 
            this.qrcodetextbox.Location = new System.Drawing.Point(327, 99);
            this.qrcodetextbox.Name = "qrcodetextbox";
            this.qrcodetextbox.Size = new System.Drawing.Size(117, 23);
            this.qrcodetextbox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Line 4";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(327, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(117, 23);
            this.textBox5.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(452, 296);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qrcodetextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productnametextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dayoftimetextbox);
            this.Controls.Add(this.printername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrinterFindButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PrinterFindButton;
        private Label label1;
        private ListBox listBox1;
        private TextBox printername;
        private Label label3;
        private TextBox dayoftimetextbox;
        private Label label2;
        private Label label4;
        private TextBox productnametextbox;
        private Label label5;
        private TextBox qrcodetextbox;
        private Label label6;
        private TextBox textBox5;
    }
}