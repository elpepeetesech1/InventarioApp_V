namespace InventarioApp_V
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
            pnlSidebar = new Panel();
            btnMostrar = new Button();
            bntAgregar = new Button();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSectionNew = new Label();
            lblAppSub = new Label();
            lblAppTitle = new Label();
            pnlMain = new Panel();
            dataGridView1 = new DataGridView();
            pnlStats = new Panel();
            pnlStat3 = new Panel();
            lblStat3Val = new Label();
            lblStat3Title = new Label();
            pnlStat2 = new Panel();
            lblStat2Val = new Label();
            lblStat2Title = new Label();
            pnlStat1 = new Panel();
            lblStat1Val = new Label();
            lblStat1Title = new Label();
            pnlMainHeader = new Panel();
            lblCatalogo = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlStats.SuspendLayout();
            pnlStat3.SuspendLayout();
            pnlStat2.SuspendLayout();
            pnlStat1.SuspendLayout();
            pnlMainHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(247, 247, 245);
            pnlSidebar.Controls.Add(btnMostrar);
            pnlSidebar.Controls.Add(bntAgregar);
            pnlSidebar.Controls.Add(txtCantidad);
            pnlSidebar.Controls.Add(txtPrecio);
            pnlSidebar.Controls.Add(txtNombre);
            pnlSidebar.Controls.Add(txtCodigo);
            pnlSidebar.Controls.Add(label4);
            pnlSidebar.Controls.Add(label3);
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Controls.Add(lblSectionNew);
            pnlSidebar.Controls.Add(lblAppSub);
            pnlSidebar.Controls.Add(lblAppTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 521);
            pnlSidebar.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Transparent;
            btnMostrar.FlatAppearance.BorderColor = Color.FromArgb(180, 178, 170);
            btnMostrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(237, 237, 233);
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = Color.FromArgb(80, 78, 72);
            btnMostrar.Location = new Point(20, 390);
            btnMostrar.Margin = new Padding(2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(200, 34);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar productos";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostar_Click;
            // 
            // bntAgregar
            // 
            bntAgregar.BackColor = Color.FromArgb(24, 95, 165);
            bntAgregar.FlatAppearance.BorderSize = 0;
            bntAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            bntAgregar.FlatStyle = FlatStyle.Flat;
            bntAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAgregar.ForeColor = Color.FromArgb(230, 241, 251);
            bntAgregar.Location = new Point(20, 348);
            bntAgregar.Margin = new Padding(2);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(200, 34);
            bntAgregar.TabIndex = 4;
            bntAgregar.Text = "+ Agregar producto";
            bntAgregar.UseVisualStyleBackColor = false;
            bntAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(20, 296);
            txtCantidad.Margin = new Padding(2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(200, 24);
            txtCantidad.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(20, 236);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(200, 24);
            txtPrecio.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(20, 176);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 24);
            txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(20, 118);
            txtCodigo.Margin = new Padding(2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 24);
            txtCodigo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 98, 92);
            label4.Location = new Point(20, 278);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 98, 92);
            label3.Location = new Point(20, 218);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 98, 92);
            label2.Location = new Point(20, 158);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(100, 98, 92);
            label1.Location = new Point(20, 100);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 7;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // lblSectionNew
            // 
            lblSectionNew.AutoSize = true;
            lblSectionNew.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSectionNew.ForeColor = Color.FromArgb(150, 148, 140);
            lblSectionNew.Location = new Point(20, 76);
            lblSectionNew.Margin = new Padding(2, 0, 2, 0);
            lblSectionNew.Name = "lblSectionNew";
            lblSectionNew.Size = new Size(94, 12);
            lblSectionNew.TabIndex = 6;
            lblSectionNew.Text = "NUEVO PRODUCTO";
            // 
            // lblAppSub
            // 
            lblAppSub.AutoSize = true;
            lblAppSub.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppSub.ForeColor = Color.FromArgb(150, 148, 140);
            lblAppSub.Location = new Point(20, 42);
            lblAppSub.Margin = new Padding(2, 0, 2, 0);
            lblAppSub.Name = "lblAppSub";
            lblAppSub.Size = new Size(121, 12);
            lblAppSub.TabIndex = 5;
            lblAppSub.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.FromArgb(30, 30, 28);
            lblAppTitle.Location = new Point(18, 16);
            lblAppTitle.Margin = new Padding(2, 0, 2, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(89, 21);
            lblAppTitle.TabIndex = 4;
            lblAppTitle.Text = "Inventario";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(dataGridView1);
            pnlMain.Controls.Add(pnlStats);
            pnlMain.Controls.Add(pnlMainHeader);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(240, 0);
            pnlMain.Margin = new Padding(2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(620, 521);
            pnlMain.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView1.GridColor = Color.FromArgb(230, 228, 222);
            dataGridView1.Location = new Point(0, 120);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(620, 401);
            dataGridView1.TabIndex = 6;
            // 
            // pnlStats
            // 
            pnlStats.Controls.Add(pnlStat3);
            pnlStats.Controls.Add(pnlStat2);
            pnlStats.Controls.Add(pnlStat1);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 52);
            pnlStats.Margin = new Padding(2);
            pnlStats.Name = "pnlStats";
            pnlStats.Size = new Size(620, 68);
            pnlStats.TabIndex = 1;
            // 
            // pnlStat3
            // 
            pnlStat3.BackColor = Color.FromArgb(247, 247, 245);
            pnlStat3.Controls.Add(lblStat3Val);
            pnlStat3.Controls.Add(lblStat3Title);
            pnlStat3.Location = new Point(414, 0);
            pnlStat3.Margin = new Padding(2);
            pnlStat3.Name = "pnlStat3";
            pnlStat3.Size = new Size(200, 68);
            pnlStat3.TabIndex = 2;
            // 
            // lblStat3Val
            // 
            lblStat3Val.AutoSize = true;
            lblStat3Val.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStat3Val.ForeColor = Color.FromArgb(59, 109, 17);
            lblStat3Val.Location = new Point(12, 28);
            lblStat3Val.Margin = new Padding(2, 0, 2, 0);
            lblStat3Val.Name = "lblStat3Val";
            lblStat3Val.Size = new Size(26, 30);
            lblStat3Val.TabIndex = 1;
            lblStat3Val.Text = "0";
            // 
            // lblStat3Title
            // 
            lblStat3Title.AutoSize = true;
            lblStat3Title.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStat3Title.ForeColor = Color.FromArgb(150, 148, 140);
            lblStat3Title.Location = new Point(14, 10);
            lblStat3Title.Margin = new Padding(2, 0, 2, 0);
            lblStat3Title.Name = "lblStat3Title";
            lblStat3Title.Size = new Size(102, 12);
            lblStat3Title.TabIndex = 0;
            lblStat3Title.Text = "PRODUCTOS ÚNICOS";
            // 
            // pnlStat2
            // 
            pnlStat2.BackColor = Color.FromArgb(247, 247, 245);
            pnlStat2.Controls.Add(lblStat2Val);
            pnlStat2.Controls.Add(lblStat2Title);
            pnlStat2.Location = new Point(207, 0);
            pnlStat2.Margin = new Padding(2);
            pnlStat2.Name = "pnlStat2";
            pnlStat2.Size = new Size(200, 68);
            pnlStat2.TabIndex = 1;
            // 
            // lblStat2Val
            // 
            lblStat2Val.AutoSize = true;
            lblStat2Val.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStat2Val.ForeColor = Color.FromArgb(30, 30, 28);
            lblStat2Val.Location = new Point(12, 28);
            lblStat2Val.Margin = new Padding(2, 0, 2, 0);
            lblStat2Val.Name = "lblStat2Val";
            lblStat2Val.Size = new Size(71, 30);
            lblStat2Val.TabIndex = 1;
            lblStat2Val.Text = "$0.00";
            // 
            // lblStat2Title
            // 
            lblStat2Title.AutoSize = true;
            lblStat2Title.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStat2Title.ForeColor = Color.FromArgb(150, 148, 140);
            lblStat2Title.Location = new Point(14, 10);
            lblStat2Title.Margin = new Padding(2, 0, 2, 0);
            lblStat2Title.Name = "lblStat2Title";
            lblStat2Title.Size = new Size(93, 12);
            lblStat2Title.TabIndex = 0;
            lblStat2Title.Text = "VALOR INVENTARIO";
            // 
            // pnlStat1
            // 
            pnlStat1.BackColor = Color.FromArgb(247, 247, 245);
            pnlStat1.Controls.Add(lblStat1Val);
            pnlStat1.Controls.Add(lblStat1Title);
            pnlStat1.Location = new Point(0, 0);
            pnlStat1.Margin = new Padding(2);
            pnlStat1.Name = "pnlStat1";
            pnlStat1.Size = new Size(200, 68);
            pnlStat1.TabIndex = 0;
            // 
            // lblStat1Val
            // 
            lblStat1Val.AutoSize = true;
            lblStat1Val.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStat1Val.ForeColor = Color.FromArgb(24, 95, 165);
            lblStat1Val.Location = new Point(12, 28);
            lblStat1Val.Margin = new Padding(2, 0, 2, 0);
            lblStat1Val.Name = "lblStat1Val";
            lblStat1Val.Size = new Size(26, 30);
            lblStat1Val.TabIndex = 1;
            lblStat1Val.Text = "0";
            // 
            // lblStat1Title
            // 
            lblStat1Title.AutoSize = true;
            lblStat1Title.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStat1Title.ForeColor = Color.FromArgb(150, 148, 140);
            lblStat1Title.Location = new Point(14, 10);
            lblStat1Title.Margin = new Padding(2, 0, 2, 0);
            lblStat1Title.Name = "lblStat1Title";
            lblStat1Title.Size = new Size(87, 12);
            lblStat1Title.TabIndex = 0;
            lblStat1Title.Text = "TOTAL ARTÍCULOS";
            // 
            // pnlMainHeader
            // 
            pnlMainHeader.BackColor = Color.White;
            pnlMainHeader.Controls.Add(lblCatalogo);
            pnlMainHeader.Dock = DockStyle.Top;
            pnlMainHeader.Location = new Point(0, 0);
            pnlMainHeader.Margin = new Padding(2);
            pnlMainHeader.Name = "pnlMainHeader";
            pnlMainHeader.Size = new Size(620, 52);
            pnlMainHeader.TabIndex = 0;
            // 
            // lblCatalogo
            // 
            lblCatalogo.AutoSize = true;
            lblCatalogo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCatalogo.ForeColor = Color.FromArgb(30, 30, 28);
            lblCatalogo.Location = new Point(20, 16);
            lblCatalogo.Margin = new Padding(2, 0, 2, 0);
            lblCatalogo.Name = "lblCatalogo";
            lblCatalogo.Size = new Size(163, 19);
            lblCatalogo.TabIndex = 0;
            lblCatalogo.Text = "Catálogo de productos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 240);
            ClientSize = new Size(860, 521);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            MinimumSize = new Size(860, 560);
            Name = "Form1";
            Text = "Inventario — Gestión de productos";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlStats.ResumeLayout(false);
            pnlStat3.ResumeLayout(false);
            pnlStat3.PerformLayout();
            pnlStat2.ResumeLayout(false);
            pnlStat2.PerformLayout();
            pnlStat1.ResumeLayout(false);
            pnlStat1.PerformLayout();
            pnlMainHeader.ResumeLayout(false);
            pnlMainHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppSub;
        private System.Windows.Forms.Label lblSectionNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button bntAgregar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMainHeader;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlStat1;
        private System.Windows.Forms.Label lblStat1Title;
        private System.Windows.Forms.Label lblStat1Val;
        private System.Windows.Forms.Panel pnlStat2;
        private System.Windows.Forms.Label lblStat2Title;
        private System.Windows.Forms.Label lblStat2Val;
        private System.Windows.Forms.Panel pnlStat3;
        private System.Windows.Forms.Label lblStat3Title;
        private System.Windows.Forms.Label lblStat3Val;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}