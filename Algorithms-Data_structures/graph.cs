using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms_Data_structures
{
    //public class Graph
    //{

    //    public class Node<T,W>
    //    {
    //        public T Value { get; set; }
    //        public List<Edge<T, W>> Edges { get; set; } //исходящие связи
    //    }
    //    public class Edge<T,W> //Ребро
    //    {
    //        public W Weight { get; set; } //вес связи
    //        public Node<T, W> Node { get; set; } // узел, на который связь ссылается
    //    }

    //    public void AddNode<T,W>(Node<T, W> node, T nodeValue, W edgeWeight)
    //    {
    //        var newNode = new Node<T, W>()
    //        {
    //            Value = nodeValue,
    //            Edges = new List<Edge<T, W>>()
    //            {
    //                new Edge<T, W>()
    //                {
    //                    Node = node,
    //                    Weight = edgeWeight,
    //                }
    //            }
    //        };

    //        var newEdge = new Edge<T, W>()
    //        {
    //            Node = newNode,
    //            Weight = edgeWeight
    //        };

    //        if (node.Edges == null)
    //        {
    //            node.Edges = new List<Edge<T, W>>();
    //        }

    //        node.Edges.Add(newEdge);
    //    }
    //}
    /// <summary>
    /// Граф
    /// </summary>
    public class Graph
    {
        /// <summary>
        /// Список вершин графа
        /// </summary>
        public List<GraphVertex> Vertices { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Graph()
        {
            Vertices = new List<GraphVertex>();
        }

        /// <summary>
        /// Добавление вершины
        /// </summary>
        /// <param name="vertexName">Имя вершины</param>
        public void AddVertex(string vertexName)
        {
            Vertices.Add(new GraphVertex(vertexName));
        }

        /// <summary>
        /// Поиск вершины
        /// </summary>
        /// <param name="vertexName">Название вершины</param>
        /// <returns>Найденная вершина</returns>
        public GraphVertex FindVertex(string vertexName)
        {
            foreach (var v in Vertices)
            {
                if (v.Name.Equals(vertexName))
                {
                    return v;
                }
            }

            return null;
        }

        /// <summary>
        /// Добавление ребра
        /// </summary>
        /// <param name="firstName">Имя первой вершины</param>
        /// <param name="secondName">Имя второй вершины</param>
        /// <param name="weight">Вес ребра соединяющего вершины</param>
        public void AddEdge(string firstName, string secondName, int weight)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2 != null && v1 != null)
            {
                v1.AddEdge(v2, weight);
                v2.AddEdge(v1, weight);
            }
        }
    }
}
