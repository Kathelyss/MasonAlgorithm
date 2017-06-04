using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasonAlgorithm
{
    /// <summary>
    /// Класс, представляющий собой граф
    /// </summary>
    class Graph
    {
        /// <summary>
        /// Список вершин графа
        /// </summary>
        public List<Vertex> Points { get; }

        /// <summary>
        /// Начальная вершина графа
        /// </summary>
        Vertex begin { get; }

        /// <summary>
        /// Конечная вершина графа
        /// </summary>
        Vertex end { get;}

        public Graph(List<Vertex> Points, Vertex begin, Vertex end)
        {
            this.Points = Points;
            this.begin = begin;
            this.end = end;
        }

        /// <summary>
        /// Получить пути графа
        /// </summary>
        public List<DataSet> GetAllWays
        {
            get
            {
                List<List<Track>> Ways = new List<List<Track>>();
                foreach (Track a in begin.OutWaysFromVertex) Ways.AddRange(this.Ways(new List<Track> { a }, a.end));
                List<DataSet> data = new List<DataSet>();
                foreach (List<Track> item in Ways) data.Add(new DataSet(item));
                return data;
            }
        }

        /// <summary>
        /// Получить дополнительные пути из заданной точки
        /// </summary>
        /// <param name="CurentWay">Список пройденных путей</param>
        /// <param name="CurPoint">Текущая вершина</param>
        /// <returns></returns>
        List<List<Track>> Ways(List<Track> CurentWay, Vertex CurPoint)
        {
            //Если пришли в ту точку в которой были, то дальше не идем.
            if (CurentWay.Any((a) => a.begin == CurPoint)) return null;

            //Если пришли в конец графа, то возвращаем путь
            if (CurPoint == end) return new List<List<Track>>() { CurentWay };
            else
            {
                //Тут храним пути из этой точки.
                var wayFromPoint = new List<List<Track>>();

                //Запускаем рекурсию на все пути из вершины.
                foreach (var a in CurPoint.OutWaysFromVertex)
                {
                    var newWay = CurentWay.ToList();
                    newWay.Add(a);
                    var Way = Ways(newWay, a.end);
                    if (Way != null) wayFromPoint.AddRange(Way);
                }
                return wayFromPoint;
            }
        }

        /// <summary>
        /// Получить контуры графа
        /// </summary>
        /// <returns></returns>
        public List<DataSet> GetAllContours
        {
            get
            {
                List<List<Track>> Cycles = new List<List<Track>>();
                foreach (var a in Points)
                {
                    foreach (var b in a.OutWaysFromVertex)
                    {
                        Cycles.AddRange(Cycle(a, new List<Track>() { b }, b.end));
                    }
                }
                Cycles = RemoveEqiul(Cycles).ToList();
                List<DataSet> data = new List<DataSet>();
                foreach (List<Track> item in Cycles) data.Add(new DataSet(item));
                return data;
            }
        }

        /// <summary>
        /// Получить дополнительные пути из заданной точки
        /// </summary>
        /// <param name="Start">Начальная вершина</param>
        /// <param name="Current_way">Список пройденных путей</param>
        /// <param name="Current_point">Текущая вершина</param>
        /// <returns></returns>
        List<List<Track>> Cycle(Vertex Start, List<Track> Current_way, Vertex Current_point)
        {
            //Если пришли в стартовую точку, то возвращаем путь
            if (Current_point == Start) return new List<List<Track>>() { Current_way };
            //Если пришли в ту точку, в которой были, то дальше не продолжаем
            if (Current_way.Any((a) => a.begin == Current_point)) return null;
            else
            {
                //Тут храним пути из этой точки.
                var wayFromPoint = new List<List<Track>>();
                //Запускаем рекурсию на все пути из вершины.
                foreach (var a in Current_point.OutWaysFromVertex)
                {
                    var newWay = Current_way.ToList();
                    newWay.Add(a);
                    var Way = Cycle(Start, newWay, a.end);
                    if (Way != null) wayFromPoint.AddRange(Way);
                }
                return wayFromPoint;
            }
        }

        /// <summary>
        /// Удаление дублированных циклов
        /// </summary>
        List<List<Track>> RemoveEqiul(List<List<Track>> IN)
        {
            List<List<Track>> OUT = IN.ToList();
            for (int i = 0; i < IN.Count; i++)
            {
                for (var j = i + 1; j < IN.Count; j++)
                {
                    if (eqiul(IN[i], IN[j])) OUT.Remove(IN[j]);
                }
            }
            return OUT;
        }

        /// <summary>
        /// Сравнение двух путей (циклов) на эквивалентность
        /// </summary>
        bool eqiul(List<Track> T1, List<Track> T2)
        {
            foreach (var a in T1)
            {
                if (!T2.Any(b => b == a)) return false;
            }
            return true;
        }

        /// <summary>
        /// Сравнивает контуры графа на их пересечение
        /// </summary>
        static bool AnySameRow(List<DataSet> Now, DataSet T1)
        {
            foreach (var f in T1.Data)
            {
                if (Now.Any((a) => a.Data.Any((b) => b.end == f.end))) return true;
            }
            return false;
        }

        /// <summary>
        /// Возвращает все множество непересекающихся контуров
        /// </summary>
        public List<DataSet[]> DisjoinCycles
        {
            get
            {
                List<DataSet[]> disjoinCycles = new List<DataSet[]>();
                int k = 2;
                while (GetDisjoinContours(GetAllContours, k).Count != 0)
                {
                    foreach (var item in GetDisjoinContours(GetAllContours, k++))
                    {
                        disjoinCycles.Add(item);
                    }
                }
                return disjoinCycles;
            }
        }

        /// <summary>
        /// Возвращает пары, тройки... непересекающихся контуров
        /// </summary>
        /// <param name="Contours">Список циклов</param>
        /// <param name="k">Значение, указывающее, какое количество несоприкасающихся вершин анализировать</param>
        /// <returns></returns>
        List<DataSet[]> GetDisjoinContours(List<DataSet> Contours, int k)
        {
            List<DataSet[]> Res = new List<DataSet[]>();
            for (int i = 0; i < Contours.Count; i++)
            {
                var check = new List<DataSet>() { Contours[i] };
                Res.AddRange(DC(Contours, k, check, i));
            }
            return Res;
        }

        /// <summary>
        /// Возвращает пару несоприкасающихся контуров
        /// </summary>
        /// <param name="Contours">Список циклов</param>
        /// <param name="k">Сколько должно быть несоприкасающихся контуров</param>
        /// <param name="cur">Контура, которые уже записаны</param>
        /// <param name="j">С какого контура просматривать дальше</param>
        /// <returns></returns>
        List<DataSet[]> DC(List<DataSet> Contours, int k, List<DataSet> cur, int j)
        {
            if (cur.Count == k)
                return new List<DataSet[]> { cur.ToArray() };
            List<DataSet[]> rez = new List<DataSet[]>();
            for (int i = j + 1; i < Contours.Count; i++)
            {
                if (!AnySameRow(cur, Contours[i]))
                {
                    var newCur = cur.ToList();
                    newCur.Add(Contours[i]);
                    rez.AddRange(DC(Contours, k, newCur, i));
                }
            }
            return rez;
        }
    }
}
