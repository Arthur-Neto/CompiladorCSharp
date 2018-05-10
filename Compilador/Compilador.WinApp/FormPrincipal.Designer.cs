namespace Compilador.WinApp
{
    partial class FormPrincipal
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.dataGridViewTableSymbol = new System.Windows.Forms.DataGridView();
            this.labelSymbols = new System.Windows.Forms.Label();
            this.labelTokens = new System.Windows.Forms.Label();
            this.dataGridViewTableTokens = new System.Windows.Forms.DataGridView();
            this.buttonCompilar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableTokens)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.importarToolStripMenuItem.Text = "Carregar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCode.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(12, 27);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(537, 642);
            this.textBoxCode.TabIndex = 1;
            // 
            // dataGridViewTableSymbol
            // 
            this.dataGridViewTableSymbol.AllowUserToAddRows = false;
            this.dataGridViewTableSymbol.AllowUserToDeleteRows = false;
            this.dataGridViewTableSymbol.AllowUserToResizeColumns = false;
            this.dataGridViewTableSymbol.AllowUserToResizeRows = false;
            this.dataGridViewTableSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTableSymbol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewTableSymbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableSymbol.Location = new System.Drawing.Point(558, 46);
            this.dataGridViewTableSymbol.Name = "dataGridViewTableSymbol";
            this.dataGridViewTableSymbol.ReadOnly = true;
            this.dataGridViewTableSymbol.Size = new System.Drawing.Size(428, 278);
            this.dataGridViewTableSymbol.TabIndex = 2;
            // 
            // labelSymbols
            // 
            this.labelSymbols.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSymbols.AutoSize = true;
            this.labelSymbols.Location = new System.Drawing.Point(555, 30);
            this.labelSymbols.Name = "labelSymbols";
            this.labelSymbols.Size = new System.Drawing.Size(101, 13);
            this.labelSymbols.TabIndex = 3;
            this.labelSymbols.Text = "Tabela de simbolos:";
            // 
            // labelTokens
            // 
            this.labelTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTokens.AutoSize = true;
            this.labelTokens.Location = new System.Drawing.Point(555, 327);
            this.labelTokens.Name = "labelTokens";
            this.labelTokens.Size = new System.Drawing.Size(93, 13);
            this.labelTokens.TabIndex = 5;
            this.labelTokens.Text = "Tabela de tokens:";
            // 
            // dataGridViewTableTokens
            // 
            this.dataGridViewTableTokens.AllowUserToAddRows = false;
            this.dataGridViewTableTokens.AllowUserToDeleteRows = false;
            this.dataGridViewTableTokens.AllowUserToResizeColumns = false;
            this.dataGridViewTableTokens.AllowUserToResizeRows = false;
            this.dataGridViewTableTokens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTableTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableTokens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewTableTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableTokens.Location = new System.Drawing.Point(558, 343);
            this.dataGridViewTableTokens.Name = "dataGridViewTableTokens";
            this.dataGridViewTableTokens.ReadOnly = true;
            this.dataGridViewTableTokens.Size = new System.Drawing.Size(428, 297);
            this.dataGridViewTableTokens.TabIndex = 4;
            // 
            // buttonCompilar
            // 
            this.buttonCompilar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCompilar.Location = new System.Drawing.Point(911, 646);
            this.buttonCompilar.Name = "buttonCompilar";
            this.buttonCompilar.Size = new System.Drawing.Size(75, 23);
            this.buttonCompilar.TabIndex = 6;
            this.buttonCompilar.Text = "Compilar";
            this.buttonCompilar.UseVisualStyleBackColor = true;
            this.buttonCompilar.Click += new System.EventHandler(this.buttonCompilar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 681);
            this.Controls.Add(this.buttonCompilar);
            this.Controls.Add(this.labelTokens);
            this.Controls.Add(this.dataGridViewTableTokens);
            this.Controls.Add(this.labelSymbols);
            this.Controls.Add(this.dataGridViewTableSymbol);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compilador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableTokens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.DataGridView dataGridViewTableSymbol;
        private System.Windows.Forms.Label labelSymbols;
        private System.Windows.Forms.Label labelTokens;
        private System.Windows.Forms.DataGridView dataGridViewTableTokens;
        private System.Windows.Forms.Button buttonCompilar;
    }
}

