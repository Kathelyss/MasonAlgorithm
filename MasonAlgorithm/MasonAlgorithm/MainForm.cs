using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasonAlgorithm
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Тут хранится класс алгоритма.
        /// </summary>
        Algorithm Mason = null;

        OrGraph graph = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            graph = FileReader.ReadFromFile(Adress.Text);
            if(graph!=null)
            {
                Mason = new Algorithm(graph);
                Adjacency_matrix.RowCount = graph.Points.Count;
                Adjacency_matrix.ColumnCount = graph.Points.Count;
                Adjacency_matrix.RowStyles.Clear();
                Adjacency_matrix.ColumnStyles.Clear();

                for (int i =0; i < graph.Points.Count;i++)
                {
                    Adjacency_matrix.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / graph.Points.Count));
                    Adjacency_matrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / graph.Points.Count));
                    for (int j = 0; j < graph.Points.Count; j++)
                    {
                        Adjacency_matrix.Controls.Add(new Label(), i, j);
                    }
                }

                for(int i = 0; i < graph.Points.Count;i++)
                {
                    for (int j = 0; j < graph.Points.Count;j++)
                    {
                        Adjacency_matrix.GetControlFromPosition(j, i).Text = "0";
                        foreach (Track t in graph.Points[i].OutWay)
                        {
                            if (t.end == graph.Points[j])
                            {
                                Adjacency_matrix.GetControlFromPosition(j, i).Text = t.PF;
                            }
                        }
                    }
                }
            }
            else
            {
                Mason = null;
                MessageBox.Show("File doesnt exist", "", MessageBoxButtons.OK);
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "xml files (*.xml)|*.xml";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Adress.Text = dialog.FileName;
            }
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            SetCyclesValuesText();
            SetWaysValueText();
            SetMaisonValue();
        }

        /// <summary>
        /// Устанавливием значения всех путей в визуализированное окошко.
        /// </summary>
        private void SetWaysValueText()
        {
            Paths.Text = "Пути:" + Environment.NewLine;
            foreach (var item in graph.getWays)
            {
                Paths.Text += item.ToString() + Environment.NewLine;
            }
        }

        /// <summary>
        /// Устанавливием значения всех контуров в визуализированное окошко.
        /// </summary>
        private void SetCyclesValuesText()
        {
            Contours.Text = "Контуры:"+Environment.NewLine;
            foreach (var item in graph.getCycle)
            {
                Contours.Text += item.ToString() + Environment.NewLine;
            }
        }

        /// <summary>
        /// Получение у установка передаточной функции графа.
        /// </summary>
        private void SetMaisonValue()
        {
            Algorithm Maison = new Algorithm(graph);
            Numerator.Text = Maison.GetNumerator();
            Denominator.Text = Maison.GetDenominator();
            CHERTA.Text = new String('_',Numerator.Text.Length);
        }
    }
}
