using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Length
    {
        private int whole;
        private int num;
        private int denom;

        public Length(int whole, int num, int denom)
        {
            this.whole = whole;
            this.num = num;
            this.denom = denom;
        }

        public static Length operator+ (Length instance, int number)
        {
            var newValue = instance.whole + number;
            var length = new Length(newValue, instance.num, instance.denom);
            return length;
        }

        public static Length operator- (Length instance, int number)
        {
            var newValue = instance.whole - number;
            var length = new Length(newValue, instance.num, instance.denom);
            return length;
        }

        public static Length operator* (Length instance, int number)
        {
            var newValue = instance.whole * number;
            var length = new Length(newValue, instance.num, instance.denom);
            return length;
        }

        public static Length operator/ (Length instance, int number)
        {
            var newValue = instance.whole / number;
            var length = new Length(newValue, instance.num, instance.denom);
            return length;
        }

        public string Verbose()
        {
            return String.Format("{0} {1}/{2}", this.whole, this.num, this.denom);
        }
    }
}
