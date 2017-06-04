using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasonAlgorithm
{
    /// <summary>
    /// Основной класс, реализующий алгоритм Мейсона
    /// </summary>
    class Algorithm
    {
        /// <summary>
        /// Граф
        /// </summary>
        public OrGraph Graph { get; }

        public Algorithm(OrGraph Graph)
        {
            this.Graph = Graph;
        }


        /// <summary>
        /// Возвращает числитель передаточной функции
        /// </summary>
        public string GetNumerator()
        {
            string lineWay = "";
            List<DataSet> Cycles = Graph.getCycle.ToList(); //Все контура графа
            List<DataSet> Ways = Graph.getWays.ToList(); //Все пути графа
            DataSet temp;
            bool check = true;
            foreach (DataSet item in Ways) //Основной цикл
            {
                if ((temp = DataSet.WayWithoutCycles(Cycles, item)) != null)
                {
                    //Записываем путь, умноженный на минор пути
                    lineWay += (temp.Sign * -1 < 0 ? "-" : "+") + "(" + item.ConvertToString() + ") * " + "( 1 " + (temp.Sign * -1 < 0 ? "-" : "+") + " " + temp.Abs() + " )";
                }
                else
                {
                    if (check)
                    {
                        lineWay += item.Abs();
                        check = false;
                    }
                    else
                    {
                        lineWay += (item.Sign < 0 ? " - " : " + ") + item.Abs();

                    }
                }
            }
            return lineWay;
        }

        /// <summary>
        /// Возвращает строковое представление определителя графа
        /// </summary>
        public string GetDenominator()
        {
            string determinant = "1";
            foreach (DataSet item in Graph.getCycle) //цикл по всем контурам
            {
                if (item.Sign < 0) determinant += " + "; //Если контур со знаком "-"
                else determinant += " - ";
                determinant += item.Abs();
            }
            //Возвращаем полный определитель с учетом пар, троек... несоприкасающихся контуров
            return determinant + DisjoinCycles();
        }

        /// <summary>
        /// Возвращает строковое значение определителя графа для всех несоприкасающихся контуров
        /// </summary>
        private string DisjoinCycles()
        {
            string result = "";
            foreach (DataSet[] item in Graph.DisjoinCycles) // Перебираем все пары, тройки, ... непересекающихся контуров
            {
                int Sign = 1;
                string testValue = "";
                foreach (DataSet temp in item) //цикл по отдельной паре, тройке... контуров
                {
                    Sign *= Convert.ToInt32(Math.Pow(-1, item.Count())) * -1 * temp.Sign;//Конечный знак
                    if (temp == item.Last())
                    {
                        testValue += temp.Abs();
                    }
                    else
                    {
                        testValue += temp.Abs() + "*";
                    }
                }
                if (Sign < 0) result += " - " + testValue;
                else result += " + " + testValue;
            }
            return result;
        }

    }

}
