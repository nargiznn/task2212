using System;

namespace task2212
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            #region task1
            ///Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            //Console.WriteLine("1.Ədədi daxil edin");
            //string num1Str = Console.ReadLine();
            //int num1 = Convert.ToInt32(num1Str);

            //Console.WriteLine("2.Ededi daxil edin");
            //string num2Str = Console.ReadLine();
            //int num2 = Convert.ToInt32(num2Str);

            //Console.WriteLine("3.Ededi daxil edin");
            //string num3Str = Console.ReadLine();
            //int num3 = Convert.ToInt32(num3Str);

            //int biggest;

            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        biggest = num1;
            //    }
            //    else
            //    {
            //        biggest = num3;
            //    }
            //}
            //if (num2 > num3)
            //{
            //    biggest = num2;
            //}
            //else
            //{
            //    biggest = num3;
            //}

            //Console.WriteLine($"En böyük eded: {biggest}");

            #endregion


            #region task2
            /////Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
            //Console.WriteLine("Yazi daxil edin");
            //string text = Console.ReadLine();
            //Console.WriteLine("herfi daxil edin");
            //string letterStr = Console.ReadLine();
            //char letter = Convert.ToChar(letterStr);

            //bool hasA = false;
            //for (int i = 0; i < text.Length; i++) ;
            //{
            //    if (text[i] == letter)
            //    {
            //        hasA = true;
            //        break;
            //    }
            //}
            //if (hasA) Console.WriteLine($"Daxil edilen yazida {letter} herfi var");
            //else Console.WriteLine($"Daxil edilen yazida {letter} herfi yoxdur");
            #endregion


            #region task3
            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
            //      Console.WriteLine("Yazi daxil edin");
            //      string text = Console.ReadLine();
            //      int count = 0;
            //      for (int i = 0; i < text.Length; i++) ;
            //      {
            //          if (text[i] == 'A')
            //              count++;
            //      }
            //Console.WriteLine($"verilmis yazida {count} sayda A herfi var");
            #endregion

            #region task4
            ////Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram.
            ////Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

            //int num;
            //do
            //{
            //    Console.WriteLine("Eded daxil edin");
            //    string numStr = Console.ReadLine();
            //    num = Convert.ToInt32(numStr);
            //}
            //while (num <= 0 || num % 2 != 0);
            //int result = num * num;
            //Console.WriteLine($"ededin kvadrati:{result}");
            #endregion

            #region task5
            ///Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram
            //Console.WriteLine("ededlerin sayini daxil edin");
            //string numsCountStr = Console.ReadLine();
            //int numsCount = Convert.ToInt32(numsCountStr);
            //int[] nums = new int[numsCount];
            //string output = "";
            //for (int i = 0; i < nums.Length; i++) 
            //{
            //    Console.WriteLine($"{i + 1}. ededi daxil edin");
            //    string numStr = Console.ReadLine();

            //    int num = Convert.ToInt32(numStr);

            //    nums[i] = num;

            //    if (i != 0 && num >= 0)

            //    {
            //        output += "+";
            //    }
            //        output += numStr;
                
            //}
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++) 
            //{
            //    sum +=nums[i];
            //}
            //output += $"={sum}";
            //Console.WriteLine(output);
            //#endregion

            #region task 6

            ///Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            ///Əgər verilmiş dəyər "programming"dirsə console-da 400 saat,
            ///"design"dırsa 250 saat, "system"dirsə 200 saat,
            ///heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

         //   bool checkInput;
         //   do
         //   {
         //       Console.WriteLine("tehsil novunu daxil edin");
         //       string etype = Console.ReadLine();
         //       checkInput = true;

         //       switch (etype)
         //       {
         //           case "programming":
         //               Console.WriteLine("400 saat");
         //               break;
         //           case "design":
         //               Console.WriteLine("250 saat");
         //               break;
         //           case "system":
         //               Console.WriteLine("200 saat");
         //               break;
         //           default:
         //               checkInput = false;
         //               Console.WriteLine("tehsil novu yanlisdir");
         //               break;

         //       }
         //   } while (!checkInput);
          #endregion
            


        }
    }
}