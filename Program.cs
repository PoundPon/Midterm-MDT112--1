using System;
namespace Midterm1 {
    class Program {
        static void Main(string[]args){
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int w1 = int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int w2 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int Overlap = 0;
            int w1h1 = 0;
            int newx1 =0;
            int newy1 = 0;
            int newx2 = 0;
            int newy2 =0;
            for(int i = x1; i <= x1+w1;i++){
                newx1++;
            }
            for(int j = y1; j <= y1+h1;j++){
                newy1++;
                }
                 for(int i = x2; i <= x2+w2;i++){
                newx2++;
            }
            for(int j = y2; j <= y2+h2;j++){
                newy2++;
                }
            if (Overlap > 8){
                Console.WriteLine("Too Much Overlaping");
            }
            else if (Overlap <= 0){
                Console.WriteLine("No Overlapping");
            }
            else if (Overlap <= 8 ){
                Console.WriteLine("Not Much Overlapping");
            }
            Console.WriteLine(newx1);
            Console.WriteLine(newy1);
            Console.WriteLine("area1 =");
            Console.WriteLine(newx1 *newx1);
            Console.WriteLine(newx2);
            Console.WriteLine(newy2);
            Console.WriteLine("area2 =");
             Console.WriteLine(newx2 *newx2);


        }
    }
}
