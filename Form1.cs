using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace comp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comp_Click(object sender, EventArgs e)
        {
            float[,] k = new float[2, 2]
            {
                {4, 5},
                {5, -1}
            };

            float[,] v = new float[2, 2]
            {
                {1, 2},
                {3, 4}
            };

            float[,] t = new float[3, 3]
            {
                {-5, 5, -9},
                {5, 1, 4},
                {3, 5, 0}
            };

            string[] l = new string[]
            {
                "1 2 3",
                "4 5 6",
                "7 8 9"
            };

            Matriz A = new Matriz(k);
            Matriz B = new Matriz(t);
            Matriz C = new Matriz(l, ' ');

            C.Ch();
            C.ImprimirMatriz();
            MessageBox.Show("Chio funcionou");

            //C.ImprimirMatriz();         

            MessageBox.Show("Everything went nice!");
        }

        private void changeDirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();

            if (f.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                Properties.Settings.Default.dir = f.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
    }

    public class Matriz
    {
        public float Determinante
        {
            get { return Determinant(); }
        }

        private float[,] map;

        public bool Quadrada
        {
            get { return map.GetLength(0) == map.GetLength(1); }
        }

        public int I
        {
            get { return map.GetLength(0); }
        }

        public int J
        {
            get { return map.GetLength(1); }
        }

        public Matriz(float[,] array)
        {
            map = array;
        }

        public Matriz(string[] lines, char separator = ' ')
        {
            int _j = lines[0].Split(separator).Length;
            int _i = lines.Length;

            float[,] _map = new float[_i, _j];

            try
            {
                for (int i = 0; i < lines.Length; ++i)
                {
                    string[] numbers = lines[i].Split(separator);
                    for (int j = 0; j < numbers.Length; ++j)
                        _map[i, j] = (float)Convert.ToDouble(numbers[j]);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }

            map = _map;
        }

        public Matriz(RichTextBox rtb, char separator = ' ')
        {
            string[] lines = rtb.Text.Split('\n');
            
            int _j = lines[0].Split(separator).Length;
            int _i = lines.Length;

            float[,] _map = new float[_i, _j];

            try
            {
                for (int i = 0; i < lines.Length; ++i)
                {
                    string[] numbers = lines[i].Split(separator);
                    for (int j = 0; j < numbers.Length; ++j)
                        _map[i, j] = (float)Convert.ToDouble(numbers[j]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }

            map = _map;
        }

        public void ImprimirMatriz()
        {
            string result = string.Empty;

            for (int i = 0; i < map.GetLength(0); ++i)
            {
                result += "\n";
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    result += " " + (map[i, j].ToString()) ?? "NULL"; 
                }
            }

            MessageBox.Show(result);
        }

#region ARITIMETICA BASICA
        // ARITIMETICA BASICA:

        public static Matriz operator +(Matriz A, float b)
        {
            for (int i = 0; i < A.map.GetLength(0); ++i)
                for (int j = 0; j < A.map.GetLength(1); ++j)
                    A.map[i, j] += b;

            return new Matriz(A.map);
        }

        public static Matriz operator -(Matriz A, float b)
        {
            for (int i = 0; i < A.map.GetLength(0); ++i)
                for (int j = 0; j < A.map.GetLength(1); ++j)
                    A.map[i, j] -= b;

            return new Matriz(A.map);
        }

        public static Matriz operator *(Matriz A, float b)
        {
            for (int i = 0; i < A.map.GetLength(0); ++i)
                for (int j = 0; j < A.map.GetLength(1); ++j)
                    A.map[i, j] *= b;

            return new Matriz(A.map);
        }

        public static Matriz operator /(Matriz A, float b)
        {
            for (int i = 0; i < A.map.GetLength(0); ++i)
                for (int j = 0; j < A.map.GetLength(1); ++j)
                    A.map[i, j] /= b;

            return new Matriz(A.map);
        }
#endregion

#region OPERACAO MATRIZ -> MATRIZ
        // OPERACAO MATRIZ -> MATRIZ

        public static Matriz operator +(Matriz A, Matriz B)
        {
            if (A.map.Length != B.map.Length)
                throw new ArgumentException();

            for (int i = 0; i < A.map.GetLength(0); ++i)
                for (int j = 0; j < A.map.GetLength(1); ++j)
                    A.map[i, j] += B.map[i, j];

            return new Matriz(A.map);
        }

        public static Matriz operator -(Matriz A, Matriz B)
        {
            if (A.map.Length != B.map.Length)
                throw new ArgumentException();

            for (int i = 0; i < A.map.GetLength(0); ++i)
                for (int j = 0; j < A.map.GetLength(1); ++j)
                    A.map[i, j] += B.map[i, j];

            return new Matriz(A.map);
        }

        public static Matriz operator *(Matriz A, Matriz B)
        {
            if (A.map.GetLength(1) != B.map.GetLength(0))
                throw new ArgumentException("A[j] não é igual a B[i]");

            float[,] _map = new float[A.map.GetLength(0), B.map.GetLength(1)];

            for (int i = 0; i < A.map.GetLength(0); i++)
            {
                for (int j = 0; j < B.map.GetLength(1); j++)
                {
                    _map[i, j] = 0;
                    for (int z = 0; z < A.map.GetLength(0); z++)
                    {
                        _map[i, j] += A.map[i, z] * B.map[z, j];
                    }
                }
            }

            MessageBox.Show(String.Format("i = {0}\nj = {1}", _map.GetLength(0), _map.GetLength(1)));
          
            return new Matriz(_map);
        }
#endregion

        #region OUTRAS OPERACOES
        // OUTRAS OPERACOES

        public Matriz Transposta()
        {
            float[,] _map = new float[map.GetLength(1), map.GetLength(0)];

            for (int i = 0; i < map.GetLength(0); i++)
                for (int j = 0; j < map.GetLength(1); j++)
                    _map[j, i] = map[i, j];

            return new Matriz(_map);
        }

        public void Transpor()
        {
            this.map = Transposta().map;
        }

        private float Determinant()
        {
            if(map.GetLength(0) != map.GetLength(1))
                throw new ArithmeticException("Não é uma matriz quadrada");

            if (map.GetLength(0) == 2)
                return (map[0, 0] * map[1, 1]) - (map[0, 1] * map[1, 0]);
            else if (map.GetLength(0) == 3)
                return 0;
            else
                throw new ArithmeticException("Matriz não é da ordem 2 ou 3"); 
        }

        public void Ch()
        {
            if(!Quadrada)
                throw new ArithmeticException("Não se pode aplicar esse método em matrizes não-quadradas");

            if(!Contem(1))
                throw new ArithmeticException("A matriz não contem 1");

            int[] index_1 = Achar(1);

            int __i = index_1[0];
            int __j = index_1[1];

            float[,] _map = new float[I - 1, J - 1];
            
            

            for (int i = 0; i < _map.GetLength(0); ++i)
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                     _map[i, j] = map[i, j] - (map[__i, j] * map[i, __j]);
                    //MessageBox.Show("Operando:\n" + String.Format("{0} = {1} - ({2} * {3})", _map[i, j], map[i + 1, j + 1], map[__i, j] * map[i, __j]));
                } 

            /*for(int i = 0; i < I; ++i)
                for (int j = 0; j < J; ++j)
                {
                    if (j != __j || i != __i)
                    { 
                        _map[i, j] = map[i, j] - (map[__i, j] * map[i, __j]);
                    }
                }*/

            map = _map;
        }

        #endregion

        #region METODOS AUXILIARES
        protected bool Contem(float n)
        {
            for (int i = 0; i < I; ++i)
                for (int j = 0; j < J; ++j)
                    if (map[i, j] == n)
                        return true;

            return false;
        }
        protected int[] Achar(float n)
        {
            for (int i = 0; i < I; ++i)
                for (int j = 0; j < J; ++j)
                    if (map[i, j] == n)
                        return new int[] 
                        {
                            i, j
                        };

            return new int[] 
            {
                -1, -1
            };
        }
        #endregion
    }
}
