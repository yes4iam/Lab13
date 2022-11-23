using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Building
    {
        string adress;
        int length;
        int width;
        int height;

        int Length

        {
            get
            {
                return length;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Ошибка! Введите положительное значение");
                else
                    length = value;
            }

        }
        int Width

        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Ошибка! Введите положительное значение");
                else
                    width = value;
            }

        }
        int Height

        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Ошибка! Введите положительное значение");
                else
                    height = value;
            }
        }
        public Building (string adress, int length, int width, int height)
        {
            this.adress = adress;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Info()
        {
            return $"Адрес: {adress}, длина: {length}, ширина: {width}, высота: {height}";
        }
        
    }
}