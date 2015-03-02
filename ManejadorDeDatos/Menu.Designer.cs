namespace ManejadorDeDatos
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.revisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDelArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuerpoDelArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // revisarToolStripMenuItem
            // 
            this.revisarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem});
            this.revisarToolStripMenuItem.Name = "revisarToolStripMenuItem";
            this.revisarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.revisarToolStripMenuItem.Text = "Revisar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDelArchivoToolStripMenuItem,
            this.cuerpoDelArchivoToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // nombreDelArchivoToolStripMenuItem
            // 
            this.nombreDelArchivoToolStripMenuItem.Name = "nombreDelArchivoToolStripMenuItem";
            this.nombreDelArchivoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.nombreDelArchivoToolStripMenuItem.Text = "Nombre del archivo";
            this.nombreDelArchivoToolStripMenuItem.Click += new System.EventHandler(this.nombreDelArchivoToolStripMenuItem_Click);
            // 
            // cuerpoDelArchivoToolStripMenuItem
            // 
            this.cuerpoDelArchivoToolStripMenuItem.Name = "cuerpoDelArchivoToolStripMenuItem";
            this.cuerpoDelArchivoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cuerpoDelArchivoToolStripMenuItem.Text = "Cuerpo del archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir Archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem revisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDelArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuerpoDelArchivoToolStripMenuItem;

    }
}