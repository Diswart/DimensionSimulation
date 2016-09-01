using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionSimulation
{
    
    public partial class Form1 : Form
    {
        public Description desc;
        //генерация графа
        static Description RandomizeThor(int n, int m, double p)//n - число вершин в одном измерении, m -количество измерений, p - вероятность генерации связи
        {
            
            List<List<int>> vertices = new List<List<int>>(); 
            List<int> coordinates = new List<int>(new int[m]);
            List<List<int>> connections = new List<List<int>>();
            Description localDesc = new Description();
            localDesc.connections = connections;
            localDesc.vertices = vertices;
            Random rand = new Random();
            vertices.Add(new List<int>(new int[m]));
            int count = m - 1;
            while (coordinates.Min() != n - 1)
            {
                while (coordinates[count] == n - 1)
                {
                    coordinates[count] = 0;
                    count--;
                }
                coordinates[count]++;
                vertices.Add(new List<int>(coordinates));
                count = m - 1;
            } // генерация матрицы содержащей координаты
            int sum = 0;
            double d = 0;
            double connectionExists = 0;
            int differencies = 0;
            for (int i = 0; i < vertices.Count; i++)
            {
                List<int> listOfLinks = new List<int>();
                for (int j = 0; j < vertices.Count; j++)
                {
                    
                    for (int k = 0; k < vertices[i].Count; k++)
                    {
                        sum += (int)Math.Pow(vertices[j][k] - vertices[i][k], 2);
                        if (vertices[j][k] != vertices[i][k])
                            differencies++;
                    }
                    d = Math.Sqrt(sum);
                    if (d == 1 || (d == (n - 1)&&differencies==1))
                    {
                        connectionExists = rand.NextDouble();
                        if (connectionExists <= p)
                        {
                            listOfLinks.Add(j);
                        }
                    }
                    sum = 0;
                    differencies = 0;
                }
                connections.Add(listOfLinks);
            }// генерация списков достижимости
            return localDesc;
        }
        static List<int> bfs(List<List<int>> matrix, int start, int end)//алгоритм нахождения пути
        {
            Queue<int> vertexes = new Queue<int>();//очередь
            List<bool> used = new List<bool>(new bool[matrix.Count + 1]);//массив посещённых вершин
            List<int> d = new List<int>(new int[matrix.Count + 1]);//массив расстояний
            List<int> p = new List<int>(new int[matrix.Count + 1]);//массив предшественников
            vertexes.Enqueue(start);
            used[start] = true;
            p[start] = -1;
            while (vertexes.Count != 0)
            {
                int v = vertexes.Dequeue();
                for (int i = 0; i < matrix[v].Count; ++i)
                {

                    int to = matrix[v][i];
                    if (!used[to])
                    {
                        used[to] = true;
                        vertexes.Enqueue(to);
                        d[to] = d[v] + 1;
                        p[to] = v;
                    }
                }
            }//посещаем все доступные вершины
            if (!used[end])
                return null;
            else
            {
                List<int> path = new List<int>();
                for (int v = end; v != -1; v = p[v])
                    path.Add(v);
                path.Reverse();
                return path;
            }//восстанавливаем путь до конечной вершины
        }



        public class Description
        {
            public List<List<int>> connections;
            public List<List<int>> vertices;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            start.Text = "";
            finish.Text = "";
            resultingPath.Text = "";
            verticesList.Items.Clear();
            neighborsList.Items.Clear();
            try {
                int vertices = Convert.ToInt32(inputVertices.Text);
                int dimensions = Convert.ToInt32(inputDimensions.Text);
                double percentage = Convert.ToDouble(inputPercent.Text);
                desc = RandomizeThor(vertices, dimensions, percentage);
                for (int i = 0; i < desc.vertices.Count; i++)
                {
                    string str = i.ToString() + ": (";
                    foreach (var inElem in desc.vertices[i])
                    {
                        str += inElem.ToString() + ", ";
                    }
                    str = str.TrimEnd(',', ' ');
                    str += ")";
                    verticesList.Items.Add(str);
                    string str1 = i.ToString() + ":   ";
                    foreach (var inElem in desc.connections[i])
                    {
                        str1 += inElem.ToString() + ", ";
                    }
                    str1 = str1.TrimEnd(',', ' ');
                    neighborsList.Items.Add(str1);
                }
            }
            catch (FormatException)
            {
                string message = "Проверьте правильность ввода вершин\\измерений\\вероятности";
                string caption = "Ошибка";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            
            
        }

        private void findPath_Click(object sender, EventArgs e)
        {
            List<int> path = bfs(desc.connections, Convert.ToInt32(start.Text), Convert.ToInt32(finish.Text));
            string str = "";
            foreach (var elem in path)
            {
                str += elem.ToString() + ", ";
            }
            str = str.TrimEnd(',', ' ');
            if (str.Length != 0)
                resultingPath.Text = str;
            else resultingPath.Text = "Нет пути!";
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
