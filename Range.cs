using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    class Range<T> where T : IComparable<T>
    {
        public T Min { get; private set; }
        public T Max { get; private set; }

        #region Constructor
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                throw new ArgumentException();
            }

            Min = min;
            Max = max;
        }
        #endregion

        #region Method        
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }


        public double Length()
        {
            if (typeof(T) == typeof(int))
            {
                return Convert.ToDouble(Max) - Convert.ToDouble(Min);
            }
            else if (typeof(T) == typeof(double) || typeof(T) == typeof(float))
            {
                return Convert.ToDouble(Max) - Convert.ToDouble(Min);
            }

            throw new NotSupportedException();
        }

        public override string ToString()
        {
            return $"Range: [{Min}, {Max}]";
        }
        #endregion
    }
}


