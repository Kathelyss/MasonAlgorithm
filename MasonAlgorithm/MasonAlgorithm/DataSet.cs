using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasonAlgorithm
{
    /// <summary>
    /// Класс для операций над путями или контурами в графе
    /// </summary>
    class DataSet
    {
        /// <summary>
        /// Список путей или контуров в графе
        /// </summary>
        public List<Track> Data { get; } = new List<Track>();

        /// <summary>
        /// Строковое представление пути или контура в графе
        /// </summary>
        public override string ToString()
        {
            string res = "";
            foreach (Track item in Data)
            {
                if (item == Data.Last()) res += item.TransferFunction;
                else res += item.TransferFunction + " -> ";
            }
            return res;
        }

        /// <summary>
        /// Математическое представление отдельного пути или контура, учитывающее знак
        /// </summary>
        public string ConvertToString()
        {
            string line = ToString().Replace(" -> ", "*");
            int Sign = Convert.ToInt32(Math.Pow(-1, line.ToCharArray().Where(a => a == '-').Count()));
            if (Sign < 0) line = "-" + line.Replace("-", "");
            else line = line.Replace("-", "");
            return line;
        }

        /// <summary>
        /// Математическое представление отдельного пути или контура, не учитывающее знак
        /// </summary>
        public string AbsValue()
        {
            string line = ConvertToString();
            if (line.Contains("-")) line = line.Replace("-", "");
            return line;
        }


        public DataSet(List<Track> data)
        {
            this.Data = new List<Track>(data);
        }


        /// <summary>
        /// Знак пути или контура
        /// </summary>
        public int Sign
        {
            get
            {
                if (ConvertToString().Contains("-")) return -1;
                return 1;
            }
        }

        /// <summary>
        /// Сравнивает некоторое множество путей или циклов, и возвращает те, которые не содержаться во втором объекте
        /// </summary>
        public static DataSet ContoursWithoutWay(List<DataSet> Contours, DataSet Way)
        {
            List<DataSet> result = Contours.ToList();
            foreach (var item in result)
            {
                if (!Equals(item, Way)) return item;
            }
            return null;
        }

        /// <summary>
        /// Сравнение двух последовательностей. Вернет true, если сравниваемые элементы имеют хотя бы одну общую вершину
        /// </summary>
        static bool Equals(DataSet first, DataSet second)
        {
            foreach (Track item in first.Data)
            {
                foreach (Track temp in second.Data)
                {
                    if (item.end == temp.end) return true;
                }
            }
            return false;
        }
    }
}
