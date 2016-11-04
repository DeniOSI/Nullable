using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nullable - струтура помогает проверять значение на корректность типа, например int? a = null
namespace GenStruct
{
    struct Nullable<T> where T: struct
    {


        public Nullable(T value)
        {
            this.value = value;
            hasValue = true;
        }
        bool hasValue;

        public T value;
        public   T Value
        {
            get { if (!hasValue) throw new InvalidOperationException("no value"); return value; }
        }


        public bool HasValue
        {
            get
            {
                return hasValue;
            }

            
        }

        public static  implicit operator Nullable<T>(T value)
        {
            return new Nullable<T>(value);
        }
        public static explicit operator T(Nullable<T> value )
        {
            return value.Value ;
        }
        public override string ToString()
        {
            if (!hasValue)
                return string.Empty;
            return this.value.ToString();  
        }
    }
}
