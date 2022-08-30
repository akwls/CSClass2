using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    // 제네릭이 적용되지 않은 것은 형변환을 해주어야 함.
    // 비교하는 대상이 Product 객체 타입이라는 것을 명시.
    class Product : IComparable<Product>
     
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public int CompareTo(Product other)
        {
            // return this.Price.CompareTo(other.Price);
            return this.Name.CompareTo(other.Name); // 가나다순 정렬
            // 기본 자료형은 기본적으로 CompareTo 메서드를 가지고 있다.

            // 0 = 같다. 음수 = 작다, 양수 = 크다.
            /*
            int result = 0;
            if(this.Price < other.Price)
            {
                result = -1;
            }
            else
            {
                result = 1;
            }
            return result;
            */
        }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }
}
