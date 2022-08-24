using System;

namespace CSClass2
{
    class Products
    {
        public int this[int i]
        {
            get { return i; }
            set { Console.WriteLine(i + "번째 상품 설정 : " + value); }
        }
    }
}