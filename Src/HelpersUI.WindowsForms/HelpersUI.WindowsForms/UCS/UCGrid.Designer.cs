﻿namespace HelpersUI.WindowsForms.UCS
{
    partial class UCGrid
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Dock = DockStyle.Fill;
            Grid.Location = new Point(0, 0);
            Grid.Name = "Grid";
            Grid.RowTemplate.Height = 25;
            Grid.Size = new Size(696, 358);
            Grid.TabIndex = 0;
            // 
            // UCGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Grid);
            Name = "UCGrid";
            Size = new Size(696, 358);
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Grid;
    }
}