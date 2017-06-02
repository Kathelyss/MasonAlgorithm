using System.Collections.Generic;
using System.Xml.Linq;

namespace MasonAlgorithm
{
    class FileReader
    {
        /// <summary>
        /// Чтение исходного графа из файла с разрешением .xml.
        /// </summary>
        /// <param name="filePath">Пуль к исходному файлу (.xml) в проекте (bin\Debug).</param>
        /// <returns>Возвращает полученный граф.</returns>
        public OrGraph ReadFromFile(string filePath)
        {
            //читаем данные из файла
            XDocument doc = XDocument.Load(filePath);
            int countOfNodes = CheckDimensions(doc);
            if (countOfNodes > 0)
            {
                // создание графа с указанным числом вершин
                List<Vertex> nodes = new List<Vertex>();
                for (int i = 0; i < countOfNodes; i++)
                    nodes.Add(new Vertex(i.ToString()));                

                //проходим по каждой строке в графе
                foreach (XElement row in doc.Root.Elements())
                {
                    // и по каждой ячейке (PF)
                    foreach (XElement PF in row.Elements())
                        if (PF.Value != "0")
                            new Track(new Vertex(row.Attribute("id").Value), new Vertex(PF.Attribute("id").Value), PF.Value);
                }

                return new OrGraph(nodes, nodes[0], nodes[nodes.Count - 1]);
            }
            return null;
        }

        /// <summary>
        /// Проверка совпадения размерностей матрицы смежности графа.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns>Возвращает 0, если размерности не совпадают и размерность, если совпадают.</returns>
        int CheckDimensions(XDocument doc)
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