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

        OrGraph Graph; // Сформированный граф.

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 440);
            this.Name = "MainForm";
            this.Text = "Алгоритм Мейсона";
            this.ResumeLayout(false);

            FileReader reader = new FileReader();
            Graph = reader.ReadFromFile("test.xml");
        }

        #endregion



        #region Воровство детектед

        /// <summary>
        /// Инициализация графа с помощью файла.
        /// </summary>
      /*  private OrGraph SetGraph()
        {
            //по идее инициализация графа должна быть здесь
            FileReader reader = new FileReader();
            Graph = reader.ReadFromFile("C:\\Users\\Kathelyss\\Desktop\\test.xml");
        }
      */

        /// <summary>
        /// Устанавливием значения всех путей в визуализированное окошко.
        /// </summary>
        private void SetWaysValueText()
        {
          //  textBoxWays.Text = "";
            foreach (var item in Graph.getWays)
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
            foreach (var item in Graph.getCycle)
            {
          //      textBoxCycles.Text += item.ToString() + Environment.NewLine;
            }
        }

        /// <summary>
        /// Получение у установка передаточной функции графа.
        /// </summary>
        private void SetMaisonValue()
        {
            Algorithm Maison = new Algorithm(Graph);
            // textBoxNumerator.Text = Maison.getNumerator();
            // textBoxDenominator.Text = Maison.getDenominator();

        }
        #endregion
    }
}

