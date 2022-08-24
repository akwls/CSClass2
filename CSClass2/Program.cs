using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> WantedString = new Wanted<string>("String");
            Wanted<int> WantedInt = new Wanted<int>(12345);
            Wanted<double> WantedDouble = new Wanted<double>(12.345);

            Console.WriteLine(WantedString.Value);
            Console.WriteLine(WantedInt.Value);
            Console.WriteLine(WantedDouble.Value);

            Products p = new Products();
            Console.WriteLine(p[4]);
            p[4] = 5;
            // 인덱서 : 클래스 변수를 변수처럼 사용가능

            Console.Write("숫자 입력 : ");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            // out 키워드 : 여러 값을 가질 수 있는 변수
            // 예외 발생 시 변환된 값, 성공 시 true 반환
            // 변수 초기화 전에 호출할 수 있지만 호출된 메서드에서 값을 초기화해야 함.

            if(result)
            {
                Console.WriteLine("입력한 숫자 : " + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력해주세요!");
            }

            int x = 0; int y = 0;
            int vx = 1; int vy = 1;
            Console.WriteLine("현재 좌표 : (" + x + ", " + y + ")");
            NextPos(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음 좌표 : (" + x + ", " + y + ")");

            // 구조체는 클래스와 달리 heap 메모리가 아니라 stack 영역에 저장됨.
            Point point;
            point.x = 10;
            point.y = 10;
            point = new Point(3, 5);
            // new 키워드는 객체를 생성하는 것이 아니라 클래스의 생성자를 호출하는 것임.
            // 새로운 객체를 생성하지 않고 기존 구조체에 있는 값을 덮어씀.
            Console.WriteLine(point.x + " / " + point.y);

            PointClass pointClassA = new PointClass(10, 20);
            PointClass pointClassB = pointClassA;
            pointClassB.x = 100; pointClassB.y = 200;
            Console.WriteLine(pointClassA.x + " / " + pointClassA.y);
            Console.WriteLine(pointClassB.x + " / " + pointClassB.y);

            PointStruct pointStructA = new PointStruct(10, 20);
            PointStruct pointStructB = pointStructA;
            pointStructB.x = 100; pointStructB.y = 200;
            Console.WriteLine(pointStructA.x + " / " + pointStructA.y);
            Console.WriteLine(pointStructB.x + " / " + pointStructB.y);
        }

        static void NextPos(int x, int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }

        struct Point
        {
            public int x;
            public int y;

            // 매개변수가 없는 기본생성자는 사용할 수 없음.
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct PointStruct
        {
            public int x;
            public int y;
            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
