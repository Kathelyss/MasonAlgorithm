using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System;

namespace MasonAlgorithm
{
    class FileReader
    {
        /// <summary>
        /// Чтение исходного графа из файла с разрешением .xml.
        /// </summary>
        /// <param name="filePath">Пуль к исходному файлу (.xml) в проекте (bin\Debug).</param>
        /// <returns>Возвращает полученный граф.</returns>
        public static Graph ReadFromFile(string filePath)
        {
            //читаем данные из файла
            if (File.Exists(filePath))
            {
                XDocument doc = XDocument.Load(filePath);
                int countOfNodes = CheckDimensions(doc);
                if (countOfNodes > 0)
                {
                    // создание графа с указанным числом вершин
                    List<Vertex> nodes = new List<Vertex>();
                    for (int i = 0; i < countOfNodes; i++)
                        nodes.Add(new Vertex(i.ToString()));

                    Vertex tmpBegin = nodes[0], tmpEnd = nodes[nodes.Count - 1];
                    //проходим по каждой строке в графе
                    foreach (XElement row in doc.Root.Elements())
                    {
                        // и по каждой ячейке (PF)
                        foreach (XElement PF in row.Elements())
                        {
                            if (PF.Value != "0")
                            {
                                new Track(nodes[Convert.ToInt32(row.Attribute("id").Value)], nodes[Convert.ToInt32(PF.Attribute("id").Value)], PF.Value);
                            }
                            if (PF.Attribute("Begin")?.Value == "yes")
                                tmpBegin = nodes[Convert.ToInt32(PF.Attribute("id").Value)];
                            if (PF.Attribute("End")?.Value == "yes")
                                tmpEnd = nodes[Convert.ToInt32(PF.Attribute("id").Value)];
                        }
                    }

                    return new Graph(nodes, tmpBegin, tmpEnd);
                }
            }
            return null;
        }

        /// <summary>
        /// Проверка совпадения размерностей матрицы смежности графа.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns>Возвращает 0, если размерности не совпадают и размерность, если совпадают.</returns>
        static int CheckDimensions(XDocument doc)
        {
            int rows = 0;
            // считаем количество строк
            foreach (XElement row in doc.Root.Elements())
                rows++;

            // проверяем совпадение числа строк и столбцов
            foreach (XElement row in doc.Root.Elements())
            {
                int cols = 0;
                foreach (XElement PF in row.Elements())
                    cols++;
                if (rows != cols)
                    return 0;
            }

            return rows;
        }
    }
}