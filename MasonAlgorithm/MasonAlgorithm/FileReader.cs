using System.Collections.Generic;
using System.Xml.Linq;

namespace MasonAlgorithm
{
    class FileReader
    {
        /// <summary>
        /// Чтение исходного графа из файла с разрешением .xml.
        /// </summary>
        /// <param name="filePath">Пуль к исходному файлу (.xml) в файловой системе.</param>
        public void ReadFromFile(string filePath)
        {
            //читаем данные из файла
            XDocument doc = XDocument.Load(filePath);
            int countOfNodes = 0;
            //проходим по каждой строке в графе
            foreach (XElement row in doc.Root.Elements())
            {
                // и по каждой ячейке (PF)
                foreach (XElement PF in row.Elements())
                    if(PF.Value != "0")
                        new Track(new Vertex(row.Attribute("id").Value), new Vertex(PF.Attribute("id").Value), PF.Value);
                countOfNodes++;
            }
            CreateGraph(countOfNodes); 
        }

        /// <summary>
        /// Создание графа с указанным числом вершин.
        /// </summary>
        public static OrGraph CreateGraph(int countOfNodes)
        {
            List<Vertex> nodes = new List<Vertex>();
            for (int i = 0; i < countOfNodes; i++)
                nodes.Add(new Vertex(i.ToString()));
            return new OrGraph(nodes, nodes[0], nodes[nodes.Count-1]);
        }
    }
}