namespace CalculadoraCP1
{
    partial class FormSobre
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            lblTitulo = new Label();
            lblIntegrantesTitulo = new Label();
            lblIntegrantes = new Label();
            lblResumoTitulo = new Label();
            txtResumo = new TextBox();
            linkGitHub = new LinkLabel();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(12, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculadora Semi-Científica";
            // 
            // lblIntegrantesTitulo
            // 
            lblIntegrantesTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblIntegrantesTitulo.Location = new Point(12, 55);
            lblIntegrantesTitulo.Name = "lblIntegrantesTitulo";
            lblIntegrantesTitulo.Size = new Size(150, 20);
            lblIntegrantesTitulo.TabIndex = 1;
            lblIntegrantesTitulo.Text = "Integrantes do grupo:";
            // 
            // lblIntegrantes
            // 
            lblIntegrantes.Location = new Point(12, 78);
            lblIntegrantes.Name = "lblIntegrantes";
            lblIntegrantes.Size = new Size(360, 60);
            lblIntegrantes.TabIndex = 2;
            lblIntegrantes.Text = "Renan da Silva Paulino - RM566610\r\nPaulo Cavalcante Caroba - RM566667";
            // 
            // lblResumoTitulo
            // 
            lblResumoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblResumoTitulo.Location = new Point(12, 140);
            lblResumoTitulo.Name = "lblResumoTitulo";
            lblResumoTitulo.Size = new Size(150, 20);
            lblResumoTitulo.TabIndex = 3;
            lblResumoTitulo.Text = "Resumo do trabalho:";
            // 
            // txtResumo
            // 
            txtResumo.Location = new Point(12, 163);
            txtResumo.Multiline = true;
            txtResumo.Name = "txtResumo";
            txtResumo.ReadOnly = true;
            txtResumo.ScrollBars = ScrollBars.Vertical;
            txtResumo.Size = new Size(360, 100);
            txtResumo.TabIndex = 4;
            txtResumo.TabStop = false;
            txtResumo.Text = resources.GetString("txtResumo.Text");
            // 
            // linkGitHub
            // 
            linkGitHub.Location = new Point(12, 273);
            linkGitHub.Name = "linkGitHub";
            linkGitHub.Size = new Size(360, 23);
            linkGitHub.TabIndex = 5;
            linkGitHub.TabStop = true;
            linkGitHub.Text = "https://github.com/cavalcantecpaulo/Cp1.Net";
            linkGitHub.LinkClicked += linkGitHub_LinkClicked;
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.Location = new Point(297, 305);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 30);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 347);
            Controls.Add(btnFechar);
            Controls.Add(linkGitHub);
            Controls.Add(txtResumo);
            Controls.Add(lblResumoTitulo);
            Controls.Add(lblIntegrantes);
            Controls.Add(lblIntegrantesTitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSobre";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblIntegrantesTitulo;
        private Label lblIntegrantes;
        private Label lblResumoTitulo;
        private TextBox txtResumo;
        private LinkLabel linkGitHub;
        private Button btnFechar;
    }
}
