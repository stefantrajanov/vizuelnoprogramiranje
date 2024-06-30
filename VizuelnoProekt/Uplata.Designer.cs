namespace VizuelnoProekt
{
    partial class Uplata
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
            this.components = new System.ComponentModel.Container();
            this.gbCombo = new System.Windows.Forms.GroupBox();
            this.tbCombo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbParnost = new System.Windows.Forms.GroupBox();
            this.cbNeparni = new System.Windows.Forms.CheckBox();
            this.cbParni = new System.Windows.Forms.CheckBox();
            this.nudPARI = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbParnost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPARI)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCombo
            // 
            this.gbCombo.Controls.Add(this.tbCombo);
            this.gbCombo.Controls.Add(this.label1);
            this.gbCombo.Location = new System.Drawing.Point(12, 26);
            this.gbCombo.Name = "gbCombo";
            this.gbCombo.Size = new System.Drawing.Size(241, 100);
            this.gbCombo.TabIndex = 0;
            this.gbCombo.TabStop = false;
            this.gbCombo.Text = "Кладење на комбинација";
            this.gbCombo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbCombo
            // 
            this.tbCombo.Location = new System.Drawing.Point(9, 53);
            this.tbCombo.Name = "tbCombo";
            this.tbCombo.Size = new System.Drawing.Size(130, 22);
            this.tbCombo.TabIndex = 1;
            this.tbCombo.TextChanged += new System.EventHandler(this.tbCombo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Внеси комбинација";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(21, 278);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbParnost
            // 
            this.gbParnost.Controls.Add(this.cbNeparni);
            this.gbParnost.Controls.Add(this.cbParni);
            this.gbParnost.Location = new System.Drawing.Point(12, 147);
            this.gbParnost.Name = "gbParnost";
            this.gbParnost.Size = new System.Drawing.Size(241, 100);
            this.gbParnost.TabIndex = 3;
            this.gbParnost.TabStop = false;
            this.gbParnost.Text = "Кладење на парност";
            // 
            // cbNeparni
            // 
            this.cbNeparni.AutoSize = true;
            this.cbNeparni.Location = new System.Drawing.Point(9, 74);
            this.cbNeparni.Name = "cbNeparni";
            this.cbNeparni.Size = new System.Drawing.Size(132, 20);
            this.cbNeparni.TabIndex = 4;
            this.cbNeparni.Text = "Први 6 непарни";
            this.cbNeparni.UseVisualStyleBackColor = true;
            this.cbNeparni.CheckedChanged += new System.EventHandler(this.cbNeparni_CheckedChanged);
            // 
            // cbParni
            // 
            this.cbParni.AutoSize = true;
            this.cbParni.Location = new System.Drawing.Point(9, 31);
            this.cbParni.Name = "cbParni";
            this.cbParni.Size = new System.Drawing.Size(116, 20);
            this.cbParni.TabIndex = 0;
            this.cbParni.Text = "Први 6 парни";
            this.cbParni.UseVisualStyleBackColor = true;
            this.cbParni.CheckedChanged += new System.EventHandler(this.cbParni_CheckedChanged);
            // 
            // nudPARI
            // 
            this.nudPARI.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPARI.Location = new System.Drawing.Point(21, 345);
            this.nudPARI.Name = "nudPARI";
            this.nudPARI.Size = new System.Drawing.Size(120, 22);
            this.nudPARI.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Уплата";
            // 
            // Uplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPARI);
            this.Controls.Add(this.gbParnost);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbCombo);
            this.Name = "Uplata";
            this.Text = "Uplata";
            this.gbCombo.ResumeLayout(false);
            this.gbCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbParnost.ResumeLayout(false);
            this.gbParnost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPARI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCombo;
        private System.Windows.Forms.TextBox tbCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbParnost;
        private System.Windows.Forms.CheckBox cbParni;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbNeparni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPARI;
    }
}