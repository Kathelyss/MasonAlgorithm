﻿namespace MasonAlgorithm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Browse = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Adress = new System.Windows.Forms.TextBox();
            this.W = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Numerator = new System.Windows.Forms.Label();
            this.Denominator = new System.Windows.Forms.Label();
            this.Contours = new System.Windows.Forms.Label();
            this.Paths = new System.Windows.Forms.Label();
            this.CHERTA = new System.Windows.Forms.Label();
            this.Compute = new System.Windows.Forms.Button();
            this.Adjacency_matrix = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(388, 11);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(32, 23);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Open
            // 
            this.Open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Open.Location = new System.Drawing.Point(426, 11);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(56, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Adress
            // 
            this.Adress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Adress.Location = new System.Drawing.Point(9, 12);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(373, 20);
            this.Adress.TabIndex = 2;
            this.Adress.Text = "Enter your .xml file address...";
            // 
            // W
            // 
            this.W.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(6, 229);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(27, 13);
            this.W.TabIndex = 3;
            this.W.Text = "W =";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Numerator);
            this.panel2.Controls.Add(this.Denominator);
            this.panel2.Controls.Add(this.Contours);
            this.panel2.Controls.Add(this.Paths);
            this.panel2.Controls.Add(this.W);
            this.panel2.Controls.Add(this.CHERTA);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 298);
            this.panel2.TabIndex = 5;
            // 
            // Numerator
            // 
            this.Numerator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Numerator.AutoSize = true;
            this.Numerator.Location = new System.Drawing.Point(33, 211);
            this.Numerator.Name = "Numerator";
            this.Numerator.Size = new System.Drawing.Size(0, 13);
            this.Numerator.TabIndex = 8;
            // 
            // Denominator
            // 
            this.Denominator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Denominator.AutoSize = true;
            this.Denominator.Location = new System.Drawing.Point(33, 247);
            this.Denominator.Name = "Denominator";
            this.Denominator.Size = new System.Drawing.Size(0, 13);
            this.Denominator.TabIndex = 7;
            // 
            // Contours
            // 
            this.Contours.AutoSize = true;
            this.Contours.Location = new System.Drawing.Point(5, 11);
            this.Contours.Name = "Contours";
            this.Contours.Size = new System.Drawing.Size(53, 13);
            this.Contours.TabIndex = 6;
            this.Contours.Text = "Контуры:";
            // 
            // Paths
            // 
            this.Paths.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Paths.AutoSize = true;
            this.Paths.Location = new System.Drawing.Point(4, 134);
            this.Paths.Name = "Paths";
            this.Paths.Size = new System.Drawing.Size(34, 13);
            this.Paths.TabIndex = 5;
            this.Paths.Text = "Пути:";
            // 
            // CHERTA
            // 
            this.CHERTA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHERTA.AutoSize = true;
            this.CHERTA.Location = new System.Drawing.Point(33, 224);
            this.CHERTA.Name = "CHERTA";
            this.CHERTA.Size = new System.Drawing.Size(0, 13);
            this.CHERTA.TabIndex = 9;
            // 
            // Compute
            // 
            this.Compute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Compute.Location = new System.Drawing.Point(488, 11);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(61, 23);
            this.Compute.TabIndex = 6;
            this.Compute.Text = "Compute";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
            // 
            // Adjacency_matrix
            // 
            this.Adjacency_matrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Adjacency_matrix.BackColor = System.Drawing.Color.White;
            this.Adjacency_matrix.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Adjacency_matrix.ColumnCount = 2;
            this.Adjacency_matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.Location = new System.Drawing.Point(3, 3);
            this.Adjacency_matrix.Name = "Adjacency_matrix";
            this.Adjacency_matrix.RowCount = 2;
            this.Adjacency_matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.Size = new System.Drawing.Size(331, 294);
            this.Adjacency_matrix.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(9, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Adjacency_matrix);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(540, 300);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(561, 350);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Browse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Алгоритм Мейсона";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Label Contours;
        private System.Windows.Forms.Label Paths;
        private System.Windows.Forms.TableLayoutPanel Adjacency_matrix;
        private System.Windows.Forms.Label Numerator;
        private System.Windows.Forms.Label Denominator;
        private System.Windows.Forms.Label CHERTA;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

