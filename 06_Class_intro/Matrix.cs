using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Class_intro
{
    //internal class Matrix
    //{
    //    int[,] matrix;
    //    public Matrix(int row, int col)
    //    {
    //        matrix = new int[row, col];
    //    }
    //    public int this[int r, int c] {
    //        get => matrix[r, c]; 
    //        set => matrix[r,c] = value; 
    //    }
    //    public override string ToString()
    //    {
    //        StringBuilder str = new StringBuilder(100);
    //        for (int i = 0; i < matrix.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < matrix.GetLength(1); j++)
    //            {
    //                str.Append( $"{matrix[i, j],7}");
    //            }
    //            str.AppendLine();
    //        }
    //        return str.ToString();
    //    }

    //}

    internal class Product
    {
        string name;
        double price;
        DateTime dateIn;

        public string Name { get=> name;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name must be not null or writespace");
                }
                if(!value.All(e=>char.IsLetter(e)))
                {
                    Exception ex = new Exception("Bad name :: must has all letter");
                    ex.Data.Add("Value", value);
                    ex.Data["TimwStamp"] = DateTime.Now;
                    ex.HelpLink = @"https://google.com.ua";
                    throw ex;
                }
                name = value;
            }
        }

        public DateTime DateIn { get=> dateIn; 
            set => dateIn = value > DateTime.Now ? value : throw new BadDateProductException("Bad date of product", value); }
    }
}
