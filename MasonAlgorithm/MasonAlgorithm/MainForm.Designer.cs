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
            this.W = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Contours = new System.Windows.Forms.Label();
            this.Paths = new System.Windows.Forms.Label();
            this.Minors = new System.Windows.Forms.Label();
            this.Compute = new System.Windows.Forms.Button();
            this.Adjacency_matrix = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(391, 11);
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
            this.Open.Location = new System.Drawing.Point(429, 11);
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
            this.Adress.Size = new System.Drawing.Size(376, 20);
            this.Adress.TabIndex = 2;
            this.Adress.Text = "Enter your .xml file address...";
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(63, 227);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(27, 13);
            this.W.TabIndex = 3;
            this.W.Text = "W =";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Contours);
            this.panel2.Controls.Add(this.Paths);
            this.panel2.Controls.Add(this.Minors);
            this.panel2.Controls.Add(this.W);
            this.panel2.Location = new System.Drawing.Point(333, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 320);
            this.panel2.TabIndex = 5;
            // 
            // Contours
            // 
            this.Contours.AutoSize = true;
            this.Contours.Location = new System.Drawing.Point(7, 11);
            this.Contours.Name = "Contours";
            this.Contours.Size = new System.Drawing.Size(51, 13);
            this.Contours.TabIndex = 6;
            this.Contours.Text = "Контура:";
            // 
            // Paths
            // 
            this.Paths.AutoSize = true;
            this.Paths.Location = new System.Drawing.Point(7, 81);
            this.Paths.Name = "Paths";
            this.Paths.Size = new System.Drawing.Size(34, 13);
            this.Paths.TabIndex = 5;
            this.Paths.Text = "Пути:";
            // 
            // Minors
            // 
            this.Minors.AutoSize = true;
            this.Minors.Location = new System.Drawing.Point(7, 152);
            this.Minors.Name = "Minors";
            this.Minors.Size = new System.Drawing.Size(51, 13);
            this.Minors.TabIndex = 4;
            this.Minors.Text = "Миноры:";
            // 
            // Compute
            // 
            this.Compute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Compute.Location = new System.Drawing.Point(491, 11);
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
            this.Adjacency_matrix.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Adjacency_matrix.ColumnCount = 2;
            this.Adjacency_matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.Location = new System.Drawing.Point(9, 38);
            this.Adjacency_matrix.Name = "Adjacency_matrix";
            this.Adjacency_matrix.RowCount = 2;
            this.Adjacency_matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Adjacency_matrix.Size = new System.Drawing.Size(318, 320);
            this.Adjacency_matrix.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 370);
            this.Controls.Add(this.Adjacency_matrix);
            this.Controls.Add(this.Compute);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Browse);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Алгоритм Мейсона";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion





        #region Воровство детектед

        OrGraph graph; // заданный граф

        /// <summary>
        /// здесь будет инициализация графа
        /// </summary>
      /*  private OrGraph SetGraph()
        {
            switch (tabControlGraphData.SelectedIndex)
            {
                case 0: return DataGraph.setTestGraphFirst();
                case 1: return DataGraph.setTestGraphSixth();
                case 2: return DataGraph.setTestGraphThird();
                case 3: return DataGraph.setTestGraphForth();
                case 4: return DataGraph.setTestGraphFifth();

                default: return null;
            }
        }*/

        /// <summary>
        /// Устанавливием значения всех путей в визуализированное окошко
        /// </summary>
        private void SetWaysValueText()
        {
          //  textBoxWays.Text = "";
            foreach (var item in graph.getWays)
            {
            //    textBoxWays.Text += item.ToString() + Environment.NewLine;
            }
        }

        /// <summary>
        /// Устанавливием значения всех контуров в визуализированное окошко.
        /// </summary>
        private void SetCyclesValuesText()
        {
          //  textBoxCycles.Text = "";
            foreach (var item in graph.getCycle)
            {
          //      textBoxCycles.Text += item.ToString() + Environment.NewLine;
            }
        }

        /// <summary>
        /// Получение у установка передаточной функции графа.
        /// </summary>
        private void SetMaisonValue()
        {
            Algorithm Maison = new Algorithm(graph);
            // textBoxNumerator.Text = Maison.getNumerator();
            // textBoxDenominator.Text = Maison.getDenominator();

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
        private System.Windows.Forms.Label Minors;
        private System.Windows.Forms.TableLayoutPanel Adjacency_matrix;
    }
}

