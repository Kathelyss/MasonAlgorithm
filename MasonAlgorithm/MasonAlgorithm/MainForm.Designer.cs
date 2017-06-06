namespace MasonAlgorithm
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
            this.W1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Denominator = new System.Windows.Forms.TextBox();
            this.Numerator = new System.Windows.Forms.TextBox();
            this.W = new System.Windows.Forms.Label();
            this.Denominator1 = new System.Windows.Forms.TextBox();
            this.Numerator1 = new System.Windows.Forms.TextBox();
            this.Contours = new System.Windows.Forms.Label();
            this.Paths = new System.Windows.Forms.Label();
            this.Compute = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Adjacency_matrix = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Adjacency_matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(509, 11);
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
            this.Open.Location = new System.Drawing.Point(547, 11);
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
            this.Adress.Size = new System.Drawing.Size(494, 20);
            this.Adress.TabIndex = 2;
            this.Adress.Text = "Enter your .xml file address...";
            // 
            // W1
            // 
            this.W1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.W1.AutoSize = true;
            this.W1.Location = new System.Drawing.Point(6, 356);
            this.W1.Name = "W1";
            this.W1.Size = new System.Drawing.Size(27, 13);
            this.W1.TabIndex = 3;
            this.W1.Text = "W =";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Denominator);
            this.panel2.Controls.Add(this.Numerator);
            this.panel2.Controls.Add(this.W);
            this.panel2.Controls.Add(this.Denominator1);
            this.panel2.Controls.Add(this.Numerator1);
            this.panel2.Controls.Add(this.Contours);
            this.panel2.Controls.Add(this.Paths);
            this.panel2.Controls.Add(this.W1);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 425);
            this.panel2.TabIndex = 5;
            // 
            // Denominator
            // 
            this.Denominator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Denominator.Location = new System.Drawing.Point(31, 260);
            this.Denominator.Margin = new System.Windows.Forms.Padding(2);
            this.Denominator.Name = "Denominator";
            this.Denominator.Size = new System.Drawing.Size(207, 20);
            this.Denominator.TabIndex = 11;
            // 
            // Numerator
            // 
            this.Numerator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Numerator.Location = new System.Drawing.Point(31, 239);
            this.Numerator.Margin = new System.Windows.Forms.Padding(2);
            this.Numerator.Name = "Numerator";
            this.Numerator.Size = new System.Drawing.Size(207, 20);
            this.Numerator.TabIndex = 10;
            // 
            // W
            // 
            this.W.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(6, 251);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(27, 13);
            this.W.TabIndex = 9;
            this.W.Text = "W =";
            // 
            // Denominator1
            // 
            this.Denominator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Denominator1.Location = new System.Drawing.Point(31, 365);
            this.Denominator1.Margin = new System.Windows.Forms.Padding(2);
            this.Denominator1.Name = "Denominator1";
            this.Denominator1.Size = new System.Drawing.Size(207, 20);
            this.Denominator1.TabIndex = 8;
            // 
            // Numerator1
            // 
            this.Numerator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Numerator1.Location = new System.Drawing.Point(31, 344);
            this.Numerator1.Margin = new System.Windows.Forms.Padding(2);
            this.Numerator1.Name = "Numerator1";
            this.Numerator1.Size = new System.Drawing.Size(207, 20);
            this.Numerator1.TabIndex = 7;
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
            this.Paths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Paths.AutoSize = true;
            this.Paths.Location = new System.Drawing.Point(6, 123);
            this.Paths.Name = "Paths";
            this.Paths.Size = new System.Drawing.Size(34, 13);
            this.Paths.TabIndex = 5;
            this.Paths.Text = "Пути:";
            // 
            // Compute
            // 
            this.Compute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Compute.Location = new System.Drawing.Point(609, 11);
            this.Compute.Name = "Compute";
            this.Compute.Size = new System.Drawing.Size(61, 23);
            this.Compute.TabIndex = 6;
            this.Compute.Text = "Compute";
            this.Compute.UseVisualStyleBackColor = true;
            this.Compute.Click += new System.EventHandler(this.Compute_Click);
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
            this.splitContainer1.Size = new System.Drawing.Size(661, 427);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 8;
            // 
            // Adjacency_matrix
            // 
            this.Adjacency_matrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Adjacency_matrix.BackgroundColor = System.Drawing.Color.White;
            this.Adjacency_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Adjacency_matrix.Location = new System.Drawing.Point(2, 2);
            this.Adjacency_matrix.Margin = new System.Windows.Forms.Padding(2);
            this.Adjacency_matrix.Name = "Adjacency_matrix";
            this.Adjacency_matrix.RowTemplate.Height = 28;
            this.Adjacency_matrix.Size = new System.Drawing.Size(407, 423);
            this.Adjacency_matrix.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 477);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Browse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Алгоритм Мейсона";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Adjacency_matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label W1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Compute;
        private System.Windows.Forms.Label Contours;
        private System.Windows.Forms.Label Paths;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Adjacency_matrix;
        private System.Windows.Forms.TextBox Denominator1;
        private System.Windows.Forms.TextBox Numerator1;
        private System.Windows.Forms.TextBox Denominator;
        private System.Windows.Forms.TextBox Numerator;
        private System.Windows.Forms.Label W;
    }
}

