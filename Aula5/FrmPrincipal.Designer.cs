namespace Aula5
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            formMenuStrip1 = new ReaLTaiizor.Controls.FormMenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            formMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip1
            // 
            formMenuStrip1.ImageScalingSize = new Size(20, 20);
            formMenuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            formMenuStrip1.Location = new Point(3, 64);
            formMenuStrip1.Name = "formMenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            formMenuStrip1.Renderer = controlRenderer1;
            formMenuStrip1.Size = new Size(794, 28);
            formMenuStrip1.TabIndex = 0;
            formMenuStrip1.Text = "formMenuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, produtoToolStripMenuItem, sairToolStripMenuItem });
            cadastroToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(224, 26);
            clienteToolStripMenuItem.Text = "Empregado";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(224, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formMenuStrip1);
            MainMenuStrip = formMenuStrip1;
            Name = "FrmPrincipal";
            Text = "Formulário Principal";
            formMenuStrip1.ResumeLayout(false);
            formMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
