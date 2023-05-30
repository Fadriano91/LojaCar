namespace LojaCar
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMarcaCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMarcaListar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMarcaConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCarro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCarroCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCarroListar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.SteelBlue;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMarca,
            this.menuCarro});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1333, 29);
            this.menu.TabIndex = 0;
            // 
            // menuMarca
            // 
            this.menuMarca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMarcaCadastrar,
            this.itemMarcaListar,
            this.itemMarcaConsultar});
            this.menuMarca.Name = "menuMarca";
            this.menuMarca.Size = new System.Drawing.Size(69, 25);
            this.menuMarca.Text = "Marca";
            // 
            // itemMarcaCadastrar
            // 
            this.itemMarcaCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.itemMarcaCadastrar.Name = "itemMarcaCadastrar";
            this.itemMarcaCadastrar.Size = new System.Drawing.Size(180, 26);
            this.itemMarcaCadastrar.Text = "Cadastrar";
            this.itemMarcaCadastrar.Click += new System.EventHandler(this.itemMarcaCadastrar_Click);
            // 
            // itemMarcaListar
            // 
            this.itemMarcaListar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.itemMarcaListar.Name = "itemMarcaListar";
            this.itemMarcaListar.Size = new System.Drawing.Size(180, 26);
            this.itemMarcaListar.Text = "Listar";
            this.itemMarcaListar.Click += new System.EventHandler(this.itemMarcaListar_Click);
            // 
            // itemMarcaConsultar
            // 
            this.itemMarcaConsultar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.itemMarcaConsultar.Name = "itemMarcaConsultar";
            this.itemMarcaConsultar.Size = new System.Drawing.Size(180, 26);
            this.itemMarcaConsultar.Text = "Consultar";
            this.itemMarcaConsultar.Click += new System.EventHandler(this.itemMarcaConsultar_Click);
            // 
            // menuCarro
            // 
            this.menuCarro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCarroCadastrar,
            this.itemCarroListar});
            this.menuCarro.Name = "menuCarro";
            this.menuCarro.Size = new System.Drawing.Size(63, 25);
            this.menuCarro.Text = "Carro";
            // 
            // itemCarroCadastrar
            // 
            this.itemCarroCadastrar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.itemCarroCadastrar.Name = "itemCarroCadastrar";
            this.itemCarroCadastrar.Size = new System.Drawing.Size(152, 26);
            this.itemCarroCadastrar.Text = "Cadastrar";
            // 
            // itemCarroListar
            // 
            this.itemCarroListar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.itemCarroListar.Name = "itemCarroListar";
            this.itemCarroListar.Size = new System.Drawing.Size(152, 26);
            this.itemCarroListar.Text = "Listar";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1333, 658);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmPrincipal";
            this.Text = "LojaCar";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuMarca;
        private System.Windows.Forms.ToolStripMenuItem itemMarcaCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemMarcaListar;
        private System.Windows.Forms.ToolStripMenuItem itemMarcaConsultar;
        private System.Windows.Forms.ToolStripMenuItem menuCarro;
        private System.Windows.Forms.ToolStripMenuItem itemCarroCadastrar;
        private System.Windows.Forms.ToolStripMenuItem itemCarroListar;
    }
}

