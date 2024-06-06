using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Figures
    {
        public char[][] Form {  get; set; }
        public Figures()
        {
            Form = new char[4][];
            for(int i = 0; i < Form.Length; i++)
            {
                Form[i] = new char[4];
            }
        }

        public void ShowFigure()
        {
            for(int i = 0;i < Form.Length;i++)
            {
                for (int j = 0; j < Form[i].Length; j++)
                {
                    if (Form[i][j] == '\0')
                    {
                        Form[i][j] = ' ';
                        Console.Write(Form[i][j]);
                    }  
                    else Console.Write(Form[i][j]);
                }
                Console.WriteLine();
            }
        }
    }

    public class Figure1: Figures
    {
        public Figure1()
        {
            Form[0][1] = '1';
            Form[1][0] = '1';
            Form[1][1] = '1';
            Form[1][2] = '1';
        }
    }

    public class Figure2 : Figures
    {
        public Figure2()
        {
            Form[0][0] = '1';
            Form[0][1] = '1';
            Form[1][1] = '1';
            Form[1][2] = '1';
        }
    }

    public class Figure3 : Figures
    {
        public Figure3()
        {
            Form[0][0] = '1';
            Form[1][0] = '1';
            Form[1][1] = '1';
            Form[1][2] = '1';
        }
    }

    public class Figure4 : Figures
    {
        public Figure4()
        {
            Form[0][3] = '1';
            Form[1][3] = '1';
            Form[2][3] = '1';
            Form[3][3] = '1';
        }
    }

    public class Figure5 : Figures
    {
        public Figure5()
        {
            Form[0][1] = '1';
            Form[0][2] = '1';
            Form[1][0] = '1';
            Form[1][1] = '1';
        }
    }

    public class Figure6 : Figures
    {
        public Figure6()
        {
            Form[0][0] = '1';
            Form[0][1] = '1';
            Form[0][2] = '1';
            Form[1][0] = '1';
        }
    }
}
