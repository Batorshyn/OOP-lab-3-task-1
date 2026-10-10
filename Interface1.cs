using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneApp
{
    public interface IParent
    {
        string Info();
        void Metod();
    }

    public class Child1 : IParent, IComparable
    {
        public double pole1;
        public double pole2;
        public double pole3;

        public Child1(double speed, double height)
        {
            pole1 = speed;
            pole2 = height;
        }

        public string Info()
        {
            return $"Пасажирський: швидкість = {pole1}, висота = {pole2}, вартість = {pole3:F2}";
        }
        public void Metod()
        {
            pole3 = pole1 * 1000 + pole2 * 100;
        }

        public int CompareTo(object o)
        {
            Child1 p = o as Child1;
            if (p != null)
            {
                return pole3.CompareTo(p.pole3);
            }
            return 0;
        }
    }
    public class Child2 : IParent, IComparable
    {
        public double pole1;
        public double pole2;
        public double pole3;
        public Child2(double speed, double height)
        {
            pole1 = speed;
            pole2 = height;
        }
        public string Info()
        {
            return $"Винищувач: швидкість = {pole1}, висота = {pole2}, вартість = {pole3:F2}";
        }
        public void Metod()
        {
            pole3 = pole1 * 3000 + pole2 * 200;
        }
        public int CompareTo(Object o)
        {
            Child2 p = o as Child2;
            if (p != null)
            {
                return pole1.CompareTo(p.pole1);
            }
            return 0;
            }
        }
    public class Child3 : IParent
    {
        public double pole1;
        public double pole2;
        public double pole3;
        public double pole4;
        public Child3(double speed, double height, double bombs)
        {
            pole1 = speed;
            pole2 = height;
            pole4 = bombs;
        }
        public string Info()
        {
            return $"Бомбардувальник: швидкість = {pole1}, висота = {pole2}, кількість бомб = {pole4}, вартість = {pole3:F2}";
        }
        public void Metod()
        {
                pole3 = pole1 * 1500 + pole2 * 150 + pole4 * 50;
        }
    }
}
