using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasonAlgorithm
{
    /// <summary>
    /// Класс, представляющий собой отдельный путь или контур в графе
    /// </summary>
    class Track
    {
        /// <summary>
        /// Вершина, из которой начинается путь
        /// </summary>
        public Vertex begin { get;}

        /// <summary>
        /// Вершина, в которую приходит путь
        /// </summary>
        public Vertex end { get; }

        /// <summary>
        /// Передаточная функция пути
        /// </summary>
        public string PF { get; }

        public Track(Vertex begin, Vertex end, string PF)
        {
            this.begin = begin;
            this.end = end;
            this.PF = PF;
            //begin.myWay.Add(this);
            //end.myWay.Add(this);
        }

        public override string ToString()
        {
            return begin + " -> " + PF + " -> " + end;
        }
    }
}
