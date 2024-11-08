namespace PetAsService.Telas
{
    partial class Favorito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorito));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            btn_excluir = new Button();
            menuStrip1 = new MenuStrip();
            buscarRaçasToolStripMenuItem = new ToolStripMenuItem();
            meusFavoritosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(23, 121);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(755, 1);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Poppins", 9F);
            label2.Location = new Point(23, 84);
            label2.Name = "label2";
            label2.Size = new Size(458, 33);
            label2.TabIndex = 4;
            label2.Text = "Aqui você encontra a lista de gatinhos favoritos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(210, 42);
            label1.TabIndex = 3;
            label1.Text = "Meus Favoritos";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(132, 147);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(544, 304);
            listBox1.TabIndex = 6;
            // 
            // btn_excluir
            // 
            btn_excluir.Font = new Font("Poppins", 9F);
            btn_excluir.Location = new Point(537, 466);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(191, 34);
            btn_excluir.TabIndex = 7;
            btn_excluir.Text = "Excluir Favorito";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscarRaçasToolStripMenuItem, meusFavoritosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            buscarRaçasToolStripMenuItem.Size = new Size(129, 29);
            buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            buscarRaçasToolStripMenuItem.Click += buscarRaçasToolStripMenuItem_Click_1;
            // 
            // meusFavoritosToolStripMenuItem
            // 
            meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            meusFavoritosToolStripMenuItem.Size = new Size(148, 29);
            meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            meusFavoritosToolStripMenuItem.Click += meusFavoritosToolStripMenuItem_Click_1;
            // 
            // Favorito
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 526);
            Controls.Add(menuStrip1);
            Controls.Add(btn_excluir);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Favorito";
            Text = "Buscar Raças Favoritas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private ListBox listBox1;
        private Button btn_excluir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private ToolStripMenuItem meusFavoritosToolStripMenuItem;
    }
}