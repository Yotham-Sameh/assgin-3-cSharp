namespace assgin_3_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 13
            //string word;
            //Console.WriteLine("Enter Word");
            //word = Console.ReadLine();
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(word[i]);
            //}
            #endregion
            #region Question14

            // 123
            // 321

            //bool flag01;
            //int num , remendier , result =0;

            //do
            //{
            //    Console.WriteLine("Enter Your Number");
            //    flag01 = int.TryParse(Console.ReadLine(), out num);


            //} while (!flag01);


            //while(num > 0)
            //{
            //    remendier = num % 10;
            //    result = (result*10)+remendier;
            //    num = num / 10;
            //}
            //Console.WriteLine($"Reversed Number : {result}");

            #endregion
            #region Question15
            //bool flag01, flag02;
            //int startNumber, endNumber, count;

            //do
            //{
            //    Console.WriteLine("Enter StartNumber: ");
            //    flag01 = int.TryParse(Console.ReadLine(), out startNumber);
            //    Console.WriteLine("Enter EndNumber: ");
            //    flag02 = int.TryParse(Console.ReadLine(), out endNumber);
            //}
            //while (!(flag01 && flag02));

            //for (int i = startNumber; i < endNumber; i++)
            //{
            //    count = 0;

            //    for (int j = 2; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //            count++; // الخطأ: تم حذف break
            //    }

            //    if (count == 0 && i != 1)
            //        Console.Write($"{i}  ");
            //}
            #endregion
            #region Question16
          
            //bool flag01 ;
            //int num ,DN ,binary=0,j;

            //do
            //{
            //    Console.WriteLine("Enter Number: ");
            //    flag01 = int.TryParse(Console.ReadLine(), out num);

            //}while (!flag01);
            //DN = num;
            //j = 1;
            //for (int i = num;i>0; i = i/2)
            //{
            //    binary = binary + (num % 2) * j;
            //    j = j * 10;
            //    num = num / 2;
            //}

            //Console.WriteLine($"Binary of {DN} = {binary}");

            #endregion
            #region Question 17

            //int x1,x2,x3,y1,y2,y3;
            //int slope01, slope02, slope03;

            //Console.WriteLine("Enter Point01");
            //x1 = int.Parse(Console.ReadLine());
            //y1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Point02");
            //x2 = int.Parse(Console.ReadLine());
            //y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Point03");
            //x3 = int.Parse(Console.ReadLine());
            //y3 = int.Parse(Console.ReadLine());

            //slope01 = (y2 - y1) / (x2 - x1);
            //slope02 = (y3-y1) / (x3 - x1);
            //slope03= (y3-y2) / (x3 - x2);

            //if(slope01 == slope02 && slope01 == slope03)
            //{
            //    Console.WriteLine("these points lie on a single straight line");
            //}
            //else
            //{
            //    Console.WriteLine("these points not lie on a single straight line");
            //}
            #endregion

            #region Question 18

            //bool flag;
            //int hours;
            //do
            //{
            //    Console.WriteLine("Enter Number Of Hours");
            //    flag = int.TryParse(Console.ReadLine(), out hours);

            //}while(!flag);

            //if (hours > 3 && hours < 2) 
            //{
            //    Console.WriteLine("they are considered high effcint"); 
            //}
            //else if (hours >= 3 && hours <= 4)
            //{
            //    Console.WriteLine("they are instructed to increase their speed");
            //}
            //else if(hours >= 4 &&  hours <= 5)
            //{ 
            //    Console.WriteLine("they are provided with training to enhance their speed");
            //}
            //else
            //{
            //    Console.WriteLine("they are required to leave the company");
            //}
            #endregion
        }
    }
}
