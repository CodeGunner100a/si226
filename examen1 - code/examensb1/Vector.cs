using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace examensb1
{
    class Vector
    {

        const int MAX = 50;
        private int[] v;
        private int n;



        public Vector()
        {
            n = 0;
            v = new int[MAX];

        }


        public void CargarRnd(int n1, int a, int b)
        {

            Random r = new Random();

            n = n1;

            for (int i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        //public void CargarManual(int n1)
        //{

        //    n = n1;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        v[i] = Conversions.ToInteger(Interaction.InputBox("", "", ""));
        //    }
        //}



        public string Descargar()
        {
            string s = "";

            for (int i = 1; i <= n; i++)
            {

                s = s + v[i] + "  |  ";
            }

            return s;
        }

        //examen

        //p1 : Seleccionar elementos repetidos donde el resultado sea unico

        public void Ejercicio1(ref Vector R)
        {
            R.n = 0;

            for (int i = 1; i <= n; i++)
            {
                int cont = 0;


                for (int j = 1; j <= n; j++)
                {
                    if (v[i] == v[j])
                    {
                        cont++;
                    }
                }


                if (cont > 1)
                {

                    if (R.Existe_ele(v[i]) == false)
                    {
                        R.insertar(v[i]);
                    }
                }
            }
        }

        public bool Existe_ele(int ele)
        {
            int i = 1;
            bool ban = false;

            while ((i <= n) && (ban == false))
            {
                if (v[i] == ele)
                {
                    ban = true;
                }
                else
                {
                    i = i + 1;
                }

            }

            return ban;
        }

        public void insertar(int elemento)
        {
            n = n + 1; v[n] = elemento;

        }

        //P2 :Econtrar elemento y frecuencia de los elementos impares del rango a y b

        public void ejercicio2(int a, int b, ref Vector e, ref Vector f)
        {
            e.n = 0;
            f.n = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] % 2 != 0) // impar
                {
                    if (!e.Existe_ele(v[i])) // no repetir
                    {
                        e.insertar(v[i]);

                        int frec = frecuencia_rango(v[i], a, b);
                        f.insertar(frec);
                    }
                }
            }

            ordenarParaleloAsc(ref e, ref f);
        }

        public int frecuencia_rango(int ele, int a, int b)
        {
            int cont = 0;

            for (int i = a; i <= b; i++)
            {
                if (v[i] == ele)
                {
                    cont++;
                }
            }

            return cont;
        }

        //Método para ordenar paralelo asc
        public void ordenarParaleloAsc(ref Vector e, ref Vector f)
        {
            for (int i = 1; i < e.n; i++)
            {
                for (int j = i + 1; j <= e.n; j++)
                {
                    if (e.v[i] > e.v[j])
                    {
                        intercambiar(ref e, ref f, i, j);
                    }
                }
            }
        }

        public void intercambiar(ref Vector e, ref Vector f, int i, int j)
        {
            int aux = e.v[i];
            e.v[i] = e.v[j];
            e.v[j] = aux;

            int aux2 = f.v[i];
            f.v[i] = f.v[j];
            f.v[j] = aux2;
        }

    }
}
