using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaColeccionesGenericas
{
    internal class Punto : IComparable
    {
        private int x;
        private int y;

        public Punto(int px, int py)
        {
            this.x = px;
            this.y = py;
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}", x, y);
        }
    }
}
