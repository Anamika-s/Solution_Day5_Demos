using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolyDeno
{
    internal interface IShape
    {
        public void GetDimensions();
        public void CalculateArea();
        public void DisplayArea();

    }

    class Square : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    class Rectangle : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }


    class Progarm1
    {
        static void Main()
        {
            IShape shape = new Square();
            shape.GetDimensions();
            shape.CalculateArea();
            shape.DisplayArea();

            shape = new Rectangle();

        }
    }
}

