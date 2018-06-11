namespace mika_desktop.Mhs
{
    partial class MhsForm
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
            this.tbSearchMhs = new System.Windows.Forms.TextBox();
            this.dgvMhs = new System.Windows.Forms.DataGridView();
            this.cbFilterMhs = new System.Windows.Forms.ComboBox();
            this.btnFilterMhs = new System.Windows.Forms.Button();
            this.btnNilaiMhs = new System.Windows.Forms.Button();
            this.btnAbsensiMhs = new System.Windows.Forms.Button();
            this.btnProfilMhs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddMhs = new System.Windows.Forms.Button();
            this.btnRemoveMhs = new System.Windows.Forms.Button();
            this.mhsNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsNIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhsNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearchMhs
            // 
            this.tbSearchMhs.Location = new System.Drawing.Point(124, 22);
            this.tbSearchMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearchMhs.Name = "tbSearchMhs";
            this.tbSearchMhs.Size = new System.Drawing.Size(300, 26);
            this.tbSearchMhs.TabIndex = 0;
            // 
            // dgvMhs
            // 
            this.dgvMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMhs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mhsNo,
            this.mhsNIM,
            this.mhsNama});
            this.dgvMhs.Location = new System.Drawing.Point(50, 64);
            this.dgvMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMhs.Name = "dgvMhs";
            this.dgvMhs.Size = new System.Drawing.Size(1545, 912);
            this.dgvMhs.TabIndex = 1;
            // 
            // cbFilterMhs
            // 
            this.cbFilterMhs.FormattingEnabled = true;
            this.cbFilterMhs.Location = new System.Drawing.Point(518, 22);
            this.cbFilterMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFilterMhs.Name = "cbFilterMhs";
            this.cbFilterMhs.Size = new System.Drawing.Size(180, 28);
            this.cbFilterMhs.TabIndex = 2;
            // 
            // btnFilterMhs
            // 
            this.btnFilterMhs.Location = new System.Drawing.Point(708, 19);
            this.btnFilterMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterMhs.Name = "btnFilterMhs";
            this.btnFilterMhs.Size = new System.Drawing.Size(99, 35);
            this.btnFilterMhs.TabIndex = 3;
            this.btnFilterMhs.Text = "Confirm";
            this.btnFilterMhs.UseVisualStyleBackColor = true;
            // 
            // btnNilaiMhs
            // 
            this.btnNilaiMhs.Location = new System.Drawing.Point(1241, 19);
            this.btnNilaiMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNilaiMhs.Name = "btnNilaiMhs";
            this.btnNilaiMhs.Size = new System.Drawing.Size(112, 35);
            this.btnNilaiMhs.TabIndex = 4;
            this.btnNilaiMhs.Text = "Nilai";
            this.btnNilaiMhs.UseVisualStyleBackColor = true;
            // 
            // btnAbsensiMhs
            // 
            this.btnAbsensiMhs.Location = new System.Drawing.Point(1362, 19);
            this.btnAbsensiMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbsensiMhs.Name = "btnAbsensiMhs";
            this.btnAbsensiMhs.Size = new System.Drawing.Size(112, 35);
            this.btnAbsensiMhs.TabIndex = 5;
            this.btnAbsensiMhs.Text = "Absensi";
            this.btnAbsensiMhs.UseVisualStyleBackColor = true;
            // 
            // btnProfilMhs
            // 
            this.btnProfilMhs.Location = new System.Drawing.Point(1483, 19);
            this.btnProfilMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProfilMhs.Name = "btnProfilMhs";
            this.btnProfilMhs.Size = new System.Drawing.Size(112, 35);
            this.btnProfilMhs.TabIndex = 6;
            this.btnProfilMhs.Text = "Profil";
            this.btnProfilMhs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filter";
            // 
            // btnAddMhs
            // 
            this.btnAddMhs.Location = new System.Drawing.Point(939, 19);
            this.btnAddMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMhs.Name = "btnAddMhs";
            this.btnAddMhs.Size = new System.Drawing.Size(112, 35);
            this.btnAddMhs.TabIndex = 9;
            this.btnAddMhs.Text = "Add";
            this.btnAddMhs.UseVisualStyleBackColor = true;
            this.btnAddMhs.Click += new System.EventHandler(this.btnAddMhs_Click);
            // 
            // btnRemoveMhs
            // 
            this.btnRemoveMhs.Location = new System.Drawing.Point(1061, 19);
            this.btnRemoveMhs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveMhs.Name = "btnRemoveMhs";
            this.btnRemoveMhs.Size = new System.Drawing.Size(112, 35);
            this.btnRemoveMhs.TabIndex = 10;
            this.btnRemoveMhs.Text = "Remove";
            this.btnRemoveMhs.UseVisualStyleBackColor = true;
            // 
            // mhsNo
            // 
            this.mhsNo.HeaderText = "No";
            this.mhsNo.Name = "mhsNo";
            // 
            // mhsNIM
            // 
            this.mhsNIM.HeaderText = "NIM";
            this.mhsNIM.Name = "mhsNIM";
            this.mhsNIM.Width = 350;
            // 
            // mhsNama
            // 
            this.mhsNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mhsNama.HeaderText = "Nama";
            this.mhsNama.Name = "mhsNama";
            // 
            // MhsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 1050);
            this.Controls.Add(this.btnRemoveMhs);
            this.Controls.Add(this.btnAddMhs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProfilMhs);
            this.Controls.Add(this.btnAbsensiMhs);
            this.Controls.Add(this.btnNilaiMhs);
            this.Controls.Add(this.btnFilterMhs);
            this.Controls.Add(this.cbFilterMhs);
            this.Controls.Add(this.dgvMhs);
            this.Controls.Add(this.tbSearchMhs);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MhsForm";
            this.Text = "MhsForm";
            this.Load += new System.EventHandler(this.MhsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchMhs;
        private System.Windows.Forms.DataGridView dgvMhs;
        private System.Windows.Forms.ComboBox cbFilterMhs;
        private System.Windows.Forms.Button btnFilterMhs;
        private System.Windows.Forms.Button btnNilaiMhs;
        private System.Windows.Forms.Button btnAbsensiMhs;
        private System.Windows.Forms.Button btnProfilMhs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddMhs;
        private System.Windows.Forms.Button btnRemoveMhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsNIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhsNama;
    }
}