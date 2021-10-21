using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._02
{
    public class Менеджер
    {
        private int ФИОМенеджера;
        private int Телефон;

        public Продажа Продажа
        {
            get => default;
            set
            {
            }
        }

        public ЗаявкаПоставщику ЗаявкаПоставщику
        {
            get => default;
            set
            {
            }
        }

        public void ПодобратьАвто()
        {
            throw new System.NotImplementedException();
        }

        public void ЗаключитьДоговор()
        {
            throw new System.NotImplementedException();
        }

        public void РасторгнутьДоговор()
        {
            throw new System.NotImplementedException();
        }
    }
}