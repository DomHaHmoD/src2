﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.affichageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTxtToolStripMenuItem,
            this.exportCsvToolStripMenuItem,
            this.exportPdfToolStripMenuItem,
            this.envoiEmailToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dataToolStripMenuItem.Text = "Fichier";
            // 
            // importTxtToolStripMenuItem
            // 
            this.importTxtToolStripMenuItem.Name = "importTxtToolStripMenuItem";
            this.importTxtToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.importTxtToolStripMenuItem.Text = "Importer données brutes";
            this.importTxtToolStripMenuItem.Click += new System.EventHandler(this.importTxtToolStripMenuItem_Click);
            // 
            // exportCsvToolStripMenuItem
            // 
            this.exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
            this.exportCsvToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.exportCsvToolStripMenuItem.Text = "Exporter Tableau (CSV)";
            this.exportCsvToolStripMenuItem.Click += new System.EventHandler(this.exportCsvToolStripMenuItem_Click);
            // 
            // exportPdfToolStripMenuItem
            // 
            this.exportPdfToolStripMenuItem.Name = "exportPdfToolStripMenuItem";
            this.exportPdfToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.exportPdfToolStripMenuItem.Text = "Exporter Rapport PDF";
            this.exportPdfToolStripMenuItem.Click += new System.EventHandler(this.exportPdfToolStripMenuItem_Click);
            // 
            // envoiEmailToolStripMenuItem
            // 
            this.envoiEmailToolStripMenuItem.Name = "envoiEmailToolStripMenuItem";
            this.envoiEmailToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.envoiEmailToolStripMenuItem.Text = "Envoyer PDF par Mail";
            this.envoiEmailToolStripMenuItem.Click += new System.EventHandler(this.envoiEmailToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphiqueToolStripMenuItem,
            this.tableauToolStripMenuItem});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // graphiqueToolStripMenuItem
            // 
            this.graphiqueToolStripMenuItem.Name = "graphiqueToolStripMenuItem";
            this.graphiqueToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.graphiqueToolStripMenuItem.Text = "Graphique";
            // 
            // tableauToolStripMenuItem
            // 
            this.tableauToolStripMenuItem.Name = "tableauToolStripMenuItem";
            this.tableauToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.tableauToolStripMenuItem.Text = "Tableau";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 315);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(12, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tableau données";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(670, 72);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Taux Humidité";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(634, 312);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(670, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Graphique données";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1336, 397);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Traitement de fichier capteur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoiEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableauToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

