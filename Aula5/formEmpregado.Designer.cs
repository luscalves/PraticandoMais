namespace Aula5
{
    partial class formEmpregado
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtIdade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnSair = new ReaLTaiizor.Controls.MaterialButton();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            lblNome = new ReaLTaiizor.Controls.MaterialLabel();
            lblIdade = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome:";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(6, 102);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(503, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtIdade
            // 
            txtIdade.AnimateReadOnly = false;
            txtIdade.AutoCompleteMode = AutoCompleteMode.None;
            txtIdade.AutoCompleteSource = AutoCompleteSource.None;
            txtIdade.BackgroundImageLayout = ImageLayout.None;
            txtIdade.CharacterCasing = CharacterCasing.Normal;
            txtIdade.Depth = 0;
            txtIdade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdade.HideSelection = true;
            txtIdade.Hint = "Idade:";
            txtIdade.LeadingIcon = null;
            txtIdade.Location = new Point(6, 156);
            txtIdade.MaxLength = 32767;
            txtIdade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtIdade.Name = "txtIdade";
            txtIdade.PasswordChar = '\0';
            txtIdade.PrefixSuffixText = null;
            txtIdade.ReadOnly = false;
            txtIdade.RightToLeft = RightToLeft.No;
            txtIdade.SelectedText = "";
            txtIdade.SelectionLength = 0;
            txtIdade.SelectionStart = 0;
            txtIdade.ShortcutsEnabled = true;
            txtIdade.Size = new Size(149, 48);
            txtIdade.TabIndex = 1;
            txtIdade.TabStop = false;
            txtIdade.TextAlign = HorizontalAlignment.Left;
            txtIdade.TrailingIcon = null;
            txtIdade.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(189, 168);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "SALVAR";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnSair
            // 
            btnSair.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSair.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSair.Depth = 0;
            btnSair.HighEmphasis = true;
            btnSair.Icon = null;
            btnSair.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSair.Location = new Point(384, 168);
            btnSair.Margin = new Padding(4, 6, 4, 6);
            btnSair.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSair.Name = "btnSair";
            btnSair.NoAccentTextColor = Color.Empty;
            btnSair.Size = new Size(64, 36);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSair.UseAccentColor = false;
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(273, 168);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(103, 36);
            btnVisualizar.TabIndex = 4;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Depth = 0;
            lblNome.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNome.Location = new Point(6, 290);
            lblNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(1, 0);
            lblNome.TabIndex = 5;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Depth = 0;
            lblIdade.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblIdade.Location = new Point(6, 308);
            lblIdade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(1, 0);
            lblIdade.TabIndex = 6;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 258);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(157, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Dados do empregado:";
            // 
            // formEmpregado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 450);
            Controls.Add(materialLabel1);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Controls.Add(btnVisualizar);
            Controls.Add(btnSair);
            Controls.Add(btnSalvar);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Name = "formEmpregado";
            Text = "Dados do Empregado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtIdade;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnSair;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
        private ReaLTaiizor.Controls.MaterialLabel lblNome;
        private ReaLTaiizor.Controls.MaterialLabel lblIdade;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}