
namespace s1x_Modded_Class
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(7, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Name Changer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton9);
            this.groupBox2.Controls.Add(this.metroButton8);
            this.groupBox2.Controls.Add(this.metroButton7);
            this.groupBox2.Controls.Add(this.metroButton6);
            this.groupBox2.Controls.Add(this.metroButton5);
            this.groupBox2.Controls.Add(this.metroButton4);
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.metroComboBox2);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(7, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modded Class";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(340, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "s1x Modded Class Editor ;  by MACHINE-GUN-SADOMY";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Class #1",
            "Class #2",
            "Class #3",
            "Class #4",
            "Class #5",
            "All Class (1 to 5)"});
            this.metroComboBox1.Location = new System.Drawing.Point(6, 28);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(256, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(268, 28);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(160, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Set Custom Name";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(6, 63);
            this.metroTextBox1.MaxLength = 20;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(256, 23);
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.Text = "Set Name Class";
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(268, 63);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(160, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Help Symbols";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Class #1",
            "Class #2",
            "Class #3",
            "Class #4",
            "Class #5",
            "All Class (1 to 5)"});
            this.metroComboBox2.Location = new System.Drawing.Point(6, 28);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(256, 29);
            this.metroComboBox2.TabIndex = 1;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(268, 28);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(160, 29);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Tactical Insertion";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(6, 63);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(256, 29);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Confussion Grenade (NO AMMO)";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(268, 63);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(160, 29);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton5.TabIndex = 6;
            this.metroButton5.Text = "Stun Modded";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(268, 98);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(160, 29);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton6.TabIndex = 7;
            this.metroButton6.Text = "Smoke Modded";
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(268, 133);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(160, 29);
            this.metroButton7.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton7.TabIndex = 8;
            this.metroButton7.Text = "Confusion Grenade";
            this.metroButton7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(6, 98);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(256, 29);
            this.metroButton8.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton8.TabIndex = 9;
            this.metroButton8.Text = "Variable Grenade (EXO MOD)";
            this.metroButton8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton8.Click += new System.EventHandler(this.metroButton8_Click);
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(6, 133);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(256, 29);
            this.metroButton9.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton9.TabIndex = 10;
            this.metroButton9.Text = "Variable Grenade (Auto Recharge)";
            this.metroButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton9.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 327);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroButton metroButton9;
    }
}

