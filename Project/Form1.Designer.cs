namespace Project
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
            pay_btn = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            custnamelbl = new Label();
            custnametxt = new TextBox();
            comboBox2 = new ComboBox();
            custcnictxt = new TextBox();
            custcniclbl = new Label();
            custphtxt = new TextBox();
            custphlbl = new Label();
            label3 = new Label();
            amounttxt = new TextBox();
            label4 = new Label();
            searchtxt = new TextBox();
            label5 = new Label();
            searchbtn = new Button();
            SuspendLayout();
            // 
            // pay_btn
            // 
            pay_btn.Location = new Point(237, 365);
            pay_btn.Name = "pay_btn";
            pay_btn.Size = new Size(94, 29);
            pay_btn.TabIndex = 0;
            pay_btn.Text = "PROCESS";
            pay_btn.UseVisualStyleBackColor = true;
            pay_btn.Click += pay_btn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Creditcard", "Cash" });
            comboBox1.Location = new Point(277, 121);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 124);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "PAYMENT MODE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 75);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = " SELECT ROOM NO";
            // 
            // custnamelbl
            // 
            custnamelbl.AutoSize = true;
            custnamelbl.Location = new Point(136, 171);
            custnamelbl.Name = "custnamelbl";
            custnamelbl.Size = new Size(130, 20);
            custnamelbl.TabIndex = 5;
            custnamelbl.Text = "CUSTOMER NAME";
            // 
            // custnametxt
            // 
            custnametxt.Location = new Point(277, 168);
            custnametxt.Name = "custnametxt";
            custnametxt.Size = new Size(151, 27);
            custnametxt.TabIndex = 6;
            custnametxt.TextChanged += custnametxt_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "r1", "r2", "r3", "r4" });
            comboBox2.Location = new Point(277, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 4;
            // 
            // custcnictxt
            // 
            custcnictxt.Location = new Point(277, 211);
            custcnictxt.Name = "custcnictxt";
            custcnictxt.Size = new Size(151, 27);
            custcnictxt.TabIndex = 8;
            // 
            // custcniclbl
            // 
            custcniclbl.AutoSize = true;
            custcniclbl.Location = new Point(136, 214);
            custcniclbl.Name = "custcniclbl";
            custcniclbl.Size = new Size(121, 20);
            custcniclbl.TabIndex = 7;
            custcniclbl.Text = "CUSTOMER CNIC";
            // 
            // custphtxt
            // 
            custphtxt.Location = new Point(277, 256);
            custphtxt.Name = "custphtxt";
            custphtxt.Size = new Size(151, 27);
            custphtxt.TabIndex = 10;
            // 
            // custphlbl
            // 
            custphlbl.AutoSize = true;
            custphlbl.Location = new Point(136, 259);
            custphlbl.Name = "custphlbl";
            custphlbl.Size = new Size(137, 20);
            custphlbl.TabIndex = 9;
            custphlbl.Text = "CUSTOMER PHONE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(293, 30);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 11;
            label3.Text = "BOOK ROOM";
            // 
            // amounttxt
            // 
            amounttxt.Location = new Point(277, 300);
            amounttxt.Name = "amounttxt";
            amounttxt.Size = new Size(151, 27);
            amounttxt.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 303);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 12;
            label4.Text = "BILL AMOUNT";
            // 
            // searchtxt
            // 
            searchtxt.Location = new Point(611, 68);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(125, 27);
            searchtxt.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(556, 30);
            label5.Name = "label5";
            label5.Size = new Size(216, 20);
            label5.TabIndex = 15;
            label5.Text = "search customer data by phone";
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(642, 115);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(94, 29);
            searchbtn.TabIndex = 16;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchbtn);
            Controls.Add(label5);
            Controls.Add(searchtxt);
            Controls.Add(amounttxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(custphtxt);
            Controls.Add(custphlbl);
            Controls.Add(custcnictxt);
            Controls.Add(custcniclbl);
            Controls.Add(custnametxt);
            Controls.Add(custnamelbl);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(pay_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pay_btn;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label custnamelbl;
        private TextBox custnametxt;
        private ComboBox comboBox2;
        private TextBox custcnictxt;
        private Label custcniclbl;
        private TextBox custphtxt;
        private Label custphlbl;
        private Label label3;
        private TextBox amounttxt;
        private Label label4;
        private TextBox searchtxt;
        private Label label5;
        private Button searchbtn;
    }
}