using System;
using System.Collections.Generic;
using System.Linq;

namespace MasonAlgorithm
{
    /// <summary>
    /// Класс, представляющий вершину графа
    /// </summary>
    class Vertex
    {
        /// <summary>
        /// Пути, в которые входит вершина
        /// </summary>
        public List<Track> Ways;

        /// <summary>
        /// Возвращает все пути, исходящие из данной вершины
        /// </summary>
        public List<Track> OutWaysFromVertex => Ways.Where((a) => a.begin == this).ToList();

        /// <summary>
        /// Номер вершины
        /// </summary>
        string Name;

        public Vertex(string Name)
        {
            this.Name = Name;
            Ways = new List<Track>();
        }

        public override string ToString()
        {
            return Name;
        }

    }
}