namespace PetAsService.Telas
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            cb_raca = new ComboBox();
            label4 = new Label();
            lb_temp = new Label();
            lb_ori = new Label();
            label7 = new Label();
            lb_des = new Label();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            btn_buscar = new Button();
            btn_favoritar = new Button();
            menuStrip1 = new MenuStrip();
            buscarRaçasToolStripMenuItem = new ToolStripMenuItem();
            meusFavoritosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold);
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(370, 42);
            label1.TabIndex = 0;
            label1.Text = "Encontre Sua Raça Favorita";
            // 
            // label2
            // 
            label2.Font = new Font("Poppins", 9F);
            label2.Location = new Point(34, 89);
            label2.Name = "label2";
            label2.Size = new Size(865, 64);
            label2.TabIndex = 1;
            label2.Text = "Ultilize a caixa de seleção de raças para buscar características sobre determinado gatinho e descobrir qual é a sua reça favorita";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(34, 165);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(868, 1);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Bold);
            label3.Location = new Point(268, 218);
            label3.Name = "label3";
            label3.Size = new Size(151, 31);
            label3.TabIndex = 3;
            label3.Text = "Raça do Gato";
            // 
            // cb_raca
            // 
            cb_raca.BackColor = SystemColors.Window;
            cb_raca.FormattingEnabled = true;
            cb_raca.Items.AddRange(new object[] { "Selecione uma Raça", "Abyssinian", "Aegean", "American Bobtail", "American Curl", "American Shorthair", "American Wirehair", "Arabian Mau", "Australian Mist", "Balinese" });
            cb_raca.Location = new Point(469, 214);
            cb_raca.Margin = new Padding(3, 4, 3, 4);
            cb_raca.Name = "cb_raca";
            cb_raca.Size = new Size(306, 39);
            cb_raca.TabIndex = 4;
            cb_raca.Text = "Selecione uma Raça";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(248, 268);
            label4.Name = "label4";
            label4.Size = new Size(169, 31);
            label4.TabIndex = 5;
            label4.Text = "Temperamento";
            // 
            // lb_temp
            // 
            lb_temp.Font = new Font("Poppins", 9F);
            lb_temp.Location = new Point(469, 268);
            lb_temp.Name = "lb_temp";
            lb_temp.Size = new Size(479, 81);
            lb_temp.TabIndex = 6;
            lb_temp.Text = "Resultado";
            // 
            // lb_ori
            // 
            lb_ori.Font = new Font("Poppins", 9F);
            lb_ori.Location = new Point(469, 349);
            lb_ori.Name = "lb_ori";
            lb_ori.Size = new Size(479, 75);
            lb_ori.TabIndex = 8;
            lb_ori.Text = "Resultado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(330, 349);
            label7.Name = "label7";
            label7.Size = new Size(87, 31);
            label7.TabIndex = 7;
            label7.Text = "Origem";
            // 
            // lb_des
            // 
            lb_des.Font = new Font("Poppins", 9F);
            lb_des.Location = new Point(469, 424);
            lb_des.Name = "lb_des";
            lb_des.Size = new Size(479, 93);
            lb_des.TabIndex = 10;
            lb_des.Text = "Resultado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(314, 424);
            label9.Name = "label9";
            label9.Size = new Size(113, 31);
            label9.TabIndex = 9;
            label9.Text = "Descrição";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(183, 531);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(574, 335);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(600, 884);
            btn_buscar.Margin = new Padding(3, 4, 3, 4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(147, 41);
            btn_buscar.TabIndex = 12;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // btn_favoritar
            // 
            btn_favoritar.Location = new Point(753, 884);
            btn_favoritar.Margin = new Padding(3, 4, 3, 4);
            btn_favoritar.Name = "btn_favoritar";
            btn_favoritar.Size = new Size(147, 41);
            btn_favoritar.TabIndex = 13;
            btn_favoritar.Text = "Favoritar";
            btn_favoritar.UseVisualStyleBackColor = true;
            btn_favoritar.Click += btn_favoritar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { buscarRaçasToolStripMenuItem, meusFavoritosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(960, 33);
            menuStrip1.TabIndex = 14;
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
            meusFavoritosToolStripMenuItem.Click += meusFavoritosToolStripMenuItem_Click;
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 977);
            Controls.Add(menuStrip1);
            Controls.Add(btn_favoritar);
            Controls.Add(btn_buscar);
            Controls.Add(pictureBox2);
            Controls.Add(lb_des);
            Controls.Add(label9);
            Controls.Add(lb_ori);
            Controls.Add(label7);
            Controls.Add(lb_temp);
            Controls.Add(label4);
            Controls.Add(cb_raca);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Poppins", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Buscar";
            Text = "Buscar Raças";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox cb_raca;
        private Label label4;
        private Label lb_temp;
        private Label lb_ori;
        private Label label7;
        private Label lb_des;
        private Label label9;
        private PictureBox pictureBox2;
        private Button btn_buscar;
        private Button btn_favoritar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private ToolStripMenuItem meusFavoritosToolStripMenuItem;
    }
}