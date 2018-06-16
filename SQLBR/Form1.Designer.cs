namespace SQLBR
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
         if(disposing && (components != null))
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.button1 = new System.Windows.Forms.Button();
         this.radioButton2 = new System.Windows.Forms.RadioButton();
         this.radioButton1 = new System.Windows.Forms.RadioButton();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.comboBox2 = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.cbIntergrated = new System.Windows.Forms.CheckBox();
         this.label1 = new System.Windows.Forms.Label();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.panel3 = new System.Windows.Forms.Panel();
         this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
         this.panel2.SuspendLayout();
         this.panel3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(411, 34);
         this.panel1.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.SystemColors.Info;
         this.panel2.Controls.Add(this.button1);
         this.panel2.Controls.Add(this.radioButton2);
         this.panel2.Controls.Add(this.radioButton1);
         this.panel2.Controls.Add(this.textBox2);
         this.panel2.Controls.Add(this.textBox1);
         this.panel2.Controls.Add(this.comboBox2);
         this.panel2.Controls.Add(this.label4);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Controls.Add(this.cbIntergrated);
         this.panel2.Controls.Add(this.label1);
         this.panel2.Controls.Add(this.comboBox1);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel2.Location = new System.Drawing.Point(0, 34);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(411, 313);
         this.panel2.TabIndex = 1;
         // 
         // button1
         // 
         this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
         this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button1.Location = new System.Drawing.Point(321, 149);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 31);
         this.button1.TabIndex = 8;
         this.button1.Text = "Execute";
         this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // radioButton2
         // 
         this.radioButton2.AutoSize = true;
         this.radioButton2.Location = new System.Drawing.Point(196, 156);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(111, 17);
         this.radioButton2.TabIndex = 7;
         this.radioButton2.Text = "Restore Database";
         this.radioButton2.UseVisualStyleBackColor = true;
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Checked = true;
         this.radioButton1.Location = new System.Drawing.Point(79, 156);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(111, 17);
         this.radioButton1.TabIndex = 6;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "Backup Database";
         this.radioButton1.UseVisualStyleBackColor = true;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(78, 98);
         this.textBox2.Name = "textBox2";
         this.textBox2.PasswordChar = '*';
         this.textBox2.Size = new System.Drawing.Size(158, 20);
         this.textBox2.TabIndex = 3;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(78, 72);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(158, 20);
         this.textBox1.TabIndex = 2;
         // 
         // comboBox2
         // 
         this.comboBox2.FormattingEnabled = true;
         this.comboBox2.Location = new System.Drawing.Point(78, 124);
         this.comboBox2.Name = "comboBox2";
         this.comboBox2.Size = new System.Drawing.Size(234, 21);
         this.comboBox2.TabIndex = 4;
         this.comboBox2.DropDown += new System.EventHandler(this.comboBox2_DropDown);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(10, 124);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(58, 13);
         this.label4.TabIndex = 5;
         this.label4.Text = "Databases";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(15, 101);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(53, 13);
         this.label3.TabIndex = 4;
         this.label3.Text = "Password";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(18, 72);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(55, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Username";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // cbIntergrated
         // 
         this.cbIntergrated.AutoSize = true;
         this.cbIntergrated.Location = new System.Drawing.Point(78, 49);
         this.cbIntergrated.Name = "cbIntergrated";
         this.cbIntergrated.Size = new System.Drawing.Size(118, 17);
         this.cbIntergrated.TabIndex = 1;
         this.cbIntergrated.Text = "Intergrated Security";
         this.cbIntergrated.UseVisualStyleBackColor = true;
         this.cbIntergrated.Click += new System.EventHandler(this.cbIntergrated_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(11, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Server List";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(78, 22);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(234, 21);
         this.comboBox1.TabIndex = 0;
         this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.memoEdit1);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel3.Location = new System.Drawing.Point(0, 224);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(411, 123);
         this.panel3.TabIndex = 2;
         // 
         // memoEdit1
         // 
         this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.memoEdit1.Location = new System.Drawing.Point(0, 0);
         this.memoEdit1.Name = "memoEdit1";
         this.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Black;
         this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
         this.memoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
         this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
         this.memoEdit1.Properties.Appearance.Options.UseFont = true;
         this.memoEdit1.Properties.Appearance.Options.UseForeColor = true;
         this.memoEdit1.Size = new System.Drawing.Size(411, 123);
         this.memoEdit1.TabIndex = 0;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(411, 347);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.panel3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox comboBox1;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.ComboBox comboBox2;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.CheckBox cbIntergrated;
      private DevExpress.XtraEditors.MemoEdit memoEdit1;
      private System.Windows.Forms.RadioButton radioButton2;
      private System.Windows.Forms.RadioButton radioButton1;
      private System.Windows.Forms.Button button1;
   }
}

