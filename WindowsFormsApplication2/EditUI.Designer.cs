namespace WindowsFormsApplication2
{
    partial class EditUI
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
            this.dbr = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.dep = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dbr
            // 
            this.dbr.Location = new System.Drawing.Point(160, 331);
            this.dbr.Name = "dbr";
            this.dbr.Size = new System.Drawing.Size(179, 20);
            this.dbr.TabIndex = 43;
            this.dbr.TextChanged += new System.EventHandler(this.dbr_TextChanged);
            this.dbr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onpress);
            this.dbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dbr_KeyPress);
            this.dbr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dbr_KeyUp);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label4.Location = new System.Drawing.Point(28, 334);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(126, 13);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Damaged Beyond Repair";
            // 
            // dep
            // 
            this.dep.Enabled = false;
            this.dep.Location = new System.Drawing.Point(104, 305);
            this.dep.Name = "dep";
            this.dep.ReadOnly = true;
            this.dep.Size = new System.Drawing.Size(235, 20);
            this.dep.TabIndex = 41;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(28, 305);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "Deployed";
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(104, 279);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(235, 20);
            this.TextBox7.TabIndex = 39;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(104, 251);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(235, 20);
            this.TextBox6.TabIndex = 38;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label12.Location = new System.Drawing.Point(28, 279);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(42, 13);
            this.Label12.TabIndex = 37;
            this.Label12.Text = "Rented";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label11.Location = new System.Drawing.Point(28, 251);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(50, 13);
            this.Label11.TabIndex = 36;
            this.Label11.Text = "Onrepair:";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button1.Location = new System.Drawing.Point(130, 372);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(116, 30);
            this.Button1.TabIndex = 35;
            this.Button1.Text = "SAVE";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(104, 217);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(235, 20);
            this.TextBox5.TabIndex = 34;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label10.Location = new System.Drawing.Point(26, 220);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(56, 13);
            this.Label10.TabIndex = 33;
            this.Label10.Text = "Damaged:";
            // 
            // TextBox4
            // 
            this.TextBox4.Enabled = false;
            this.TextBox4.Location = new System.Drawing.Point(104, 182);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(235, 20);
            this.TextBox4.TabIndex = 32;
            this.TextBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label9.Location = new System.Drawing.Point(26, 185);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(63, 13);
            this.Label9.TabIndex = 31;
            this.Label9.Text = "Deployable:";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(104, 136);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(235, 20);
            this.TextBox3.TabIndex = 30;
            this.TextBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label7.Location = new System.Drawing.Point(26, 139);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(38, 13);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "Stock:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(104, 106);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(235, 20);
            this.TextBox2.TabIndex = 28;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label5.Location = new System.Drawing.Point(26, 109);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(42, 13);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "Details:";
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Staging",
            "Lights",
            "Speakers",
            "Misc.",
            "Video",
            "LED Wall",
            "LCD"});
            this.ComboBox1.Location = new System.Drawing.Point(104, 73);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox1.TabIndex = 26;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label3.Location = new System.Drawing.Point(26, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Category:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(26, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Name:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(104, 41);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(235, 20);
            this.TextBox1.TabIndex = 23;
            // 
            // EditUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(382, 414);
            this.Controls.Add(this.dbr);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Item Details";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox dbr;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox dep;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox1;
        
    }
}