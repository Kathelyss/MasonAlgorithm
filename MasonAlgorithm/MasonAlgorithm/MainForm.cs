﻿using System;
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

        Graph graph = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            graph = FileReader.ReadFromFile(Adress.Text);
            if(graph!=null)
            {
                Adjacency_matrix.Controls.Clear();

                Mason = new Algorithm(graph);
                Adjacency_matrix.RowCount = graph.Points.Count;
                Adjacency_matrix.ColumnCount = graph.Points.Count;
                

                for(int i = 0; i < graph.Points.Count;i++)
                {
                    for (int j = 0; j < graph.Points.Count;j++)
                    {
                        Adjacency_matrix.Rows[i].Cells[j].Value = "0";
                        foreach (Track t in graph.Points[i].OutWaysFromVertex)
                        {
                            if (t.end == graph.Points[j])
                            {
                                Adjacency_matrix.Rows[i].Cells[j].Value = t.TransferFunction;
                            }
                        }
                    }
                }
            }
            else
            {
                Mason = null;
                graph = null;
                MessageBox.Show("File doesnt exist", "", MessageBoxButtons.OK);
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = Environment.CurrentDirectory;
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
            if (Mason != null && graph != null)
            {
                SetCyclesValuesText();
                SetWaysValueText();
                SetMaisonValue();
            }
            else
            {
                MessageBox.Show("No file loaded", "", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Устанавливием значения всех путей в визуализированное окошко.
        /// </summary>
        private void SetWaysValueText()
        {
            Paths.Text = "Пути: " + Environment.NewLine;
            foreach (var item in graph.GetAllWays)
            {
                Paths.Text += item + Environment.NewLine;
            }
        }

        /// <summary>
        /// Устанавливием значения всех контуров в визуализированное окошко.
        /// </summary>
        private void SetCyclesValuesText()
        {
            Contours.Text = "Контуры: "+Environment.NewLine;
            foreach (var item in graph.GetAllContours)
            {
                Contours.Text += item + Environment.NewLine;
            }
        }

        /// <summary>
        /// Получение у установка передаточной функции графа.
        /// </summary>
        private void SetMaisonValue()
        {
            Algorithm Maison = new Algorithm(graph);
            Numerator1.Text = Maison.GetNumerator();
            Denominator1.Text = Maison.GetDenominator();
            if (Numerator1.Text.Length > Denominator1.Text.Length)
            {
                //CHERTA.Text = new String('_', Numerator.Text.Length);
            }
            else
            {
                //CHERTA.Text = new String('_', Denominator.Text.Length);
            }
        }
    }
}
