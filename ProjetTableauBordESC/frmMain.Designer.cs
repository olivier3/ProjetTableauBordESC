namespace ProjetTableauBordESC
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInterface = new System.Windows.Forms.TabPage();
            this.scInterfaces = new System.Windows.Forms.SplitContainer();
            this.dgvInterfaces = new System.Windows.Forms.DataGridView();
            this.colNomInterface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIPv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFabricant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgInterfaceSelectionne = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInterfaces)).BeginInit();
            this.scInterfaces.Panel1.SuspendLayout();
            this.scInterfaces.Panel2.SuspendLayout();
            this.scInterfaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterfaces)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInterface);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageInterface
            // 
            this.tabPageInterface.Controls.Add(this.scInterfaces);
            this.tabPageInterface.Location = new System.Drawing.Point(4, 25);
            this.tabPageInterface.Name = "tabPageInterface";
            this.tabPageInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInterface.Size = new System.Drawing.Size(792, 421);
            this.tabPageInterface.TabIndex = 0;
            this.tabPageInterface.Text = "Interfaces";
            this.tabPageInterface.UseVisualStyleBackColor = true;
            // 
            // scInterfaces
            // 
            this.scInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scInterfaces.Location = new System.Drawing.Point(3, 3);
            this.scInterfaces.Name = "scInterfaces";
            // 
            // scInterfaces.Panel1
            // 
            this.scInterfaces.Panel1.Controls.Add(this.dgvInterfaces);
            // 
            // scInterfaces.Panel2
            // 
            this.scInterfaces.Panel2.Controls.Add(this.pgInterfaceSelectionne);
            this.scInterfaces.Size = new System.Drawing.Size(786, 415);
            this.scInterfaces.SplitterDistance = 397;
            this.scInterfaces.TabIndex = 2;
            // 
            // dgvInterfaces
            // 
            this.dgvInterfaces.AllowUserToAddRows = false;
            this.dgvInterfaces.AllowUserToDeleteRows = false;
            this.dgvInterfaces.AllowUserToResizeRows = false;
            this.dgvInterfaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterfaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomInterface,
            this.colIPv4,
            this.colFabricant});
            this.dgvInterfaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInterfaces.Location = new System.Drawing.Point(0, 0);
            this.dgvInterfaces.Name = "dgvInterfaces";
            this.dgvInterfaces.ReadOnly = true;
            this.dgvInterfaces.RowHeadersVisible = false;
            this.dgvInterfaces.RowHeadersWidth = 51;
            this.dgvInterfaces.RowTemplate.Height = 24;
            this.dgvInterfaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterfaces.Size = new System.Drawing.Size(397, 415);
            this.dgvInterfaces.TabIndex = 0;
            this.dgvInterfaces.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvInterfaces_DataError);
            this.dgvInterfaces.SelectionChanged += new System.EventHandler(this.dgvInterfaces_SelectionChanged);
            // 
            // colNomInterface
            // 
            this.colNomInterface.DataPropertyName = "NomCarte";
            this.colNomInterface.HeaderText = "Interface";
            this.colNomInterface.MinimumWidth = 6;
            this.colNomInterface.Name = "colNomInterface";
            this.colNomInterface.ReadOnly = true;
            this.colNomInterface.Width = 125;
            // 
            // colIPv4
            // 
            this.colIPv4.DataPropertyName = "IPv4";
            this.colIPv4.HeaderText = "IPv4";
            this.colIPv4.MinimumWidth = 6;
            this.colIPv4.Name = "colIPv4";
            this.colIPv4.ReadOnly = true;
            this.colIPv4.Width = 125;
            // 
            // colFabricant
            // 
            this.colFabricant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFabricant.DataPropertyName = "Fabricant";
            this.colFabricant.HeaderText = "Fabricant";
            this.colFabricant.MinimumWidth = 6;
            this.colFabricant.Name = "colFabricant";
            this.colFabricant.ReadOnly = true;
            // 
            // pgInterfaceSelectionne
            // 
            this.pgInterfaceSelectionne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgInterfaceSelectionne.Location = new System.Drawing.Point(0, 0);
            this.pgInterfaceSelectionne.Name = "pgInterfaceSelectionne";
            this.pgInterfaceSelectionne.Size = new System.Drawing.Size(385, 415);
            this.pgInterfaceSelectionne.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageInterface.ResumeLayout(false);
            this.scInterfaces.Panel1.ResumeLayout(false);
            this.scInterfaces.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInterfaces)).EndInit();
            this.scInterfaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterfaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageInterface;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer scInterfaces;
        private System.Windows.Forms.DataGridView dgvInterfaces;
        private System.Windows.Forms.PropertyGrid pgInterfaceSelectionne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomInterface;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIPv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFabricant;
    }
}

