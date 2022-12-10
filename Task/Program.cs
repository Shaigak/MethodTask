

#region Task1
////static void division(int n)
////{
////    if(n%3==0 & n % 7 == 0)
////    {
////        Console.WriteLine("Eded 3e ve 7e bolunur");
////    }
////    else
////    {
////        Console.WriteLine("Eded 3 e ve 7e bolunmur");
////    }
////}

////division(21);
#endregion



#region Task2
//n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

////static void sum(int num1, int num2)

////{
////    int res = 0;
////    if (num1 % 2 == 0 & num2 % 2 == 0)
////    {
////        res = num1 + num2;
////        Console.WriteLine(res);
////    }
////    else
////    {
////        Console.WriteLine("Duzgun ededleri daxil edin");
////    }
////}


//sum(10, 48);
#endregion



#region Task3
//Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//static void ShowNumber(int num1, int num2)
//{
//    int sum = 0;
//    for (int i = num1; i < num2; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum = sum + i;

//        }

//    }
//    Console.WriteLine(sum);

}

ShowNumber(10, 20);
#endregion



#region Task4
Verilmish arrayin icindeki tek ededlerin cemini tapin.

  static void Arr()
{
    int sum = 0;
    int[] arry = { 1, 5, 7, 8, 13, 11, 15, 17 };

    for (int i = 0; i < arry.Length; i++)
    {
        if (arry[i] % 2 == 1)
        {
            sum = sum + arry[i];
        }
    }
    Console.WriteLine(sum);
}


Arr();

#endregion



#region Task5
////Verilmish arrayin icindeki cut ededlerin sayini tapin.

//    static void Arrodd()
//{int count = 0; 
//    int[] arry = { 1, 5, 4, 6, 10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, };
//    for (int i = 0; i < arry.Length; i++)
//    {
//        if (arry[i] % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}
//Arrodd();
#endregion



#region Task6
6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.



    static void Numbers(int num1, int num2)
{
    int count = 0;
    for (int i = num1; i < num2; i++)
    {
        if (i % 2 == 1)
        {
            count++;
        }

    }
    Console.WriteLine(count);
}
Numbers(15, 40);
#endregion



#region Task7
Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.



static void EvenPlural(int n, int m)
{
    int sum = 0;
    for (int i = n; i < m; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + i;
        }
    }
    Console.WriteLine(sum);
}

EvenPlural(12, 24);
#endregion



#region Task8
Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

static void CountPlural(int a, int b)
{
    int count = 0;
    for (int i = a; i < b; i++)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
CountPlural(12, 22);

#endregion


#region Task9
//Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//static void SimpleOrNot(int num1)
//{
//    int count = 0;
//    if (num1 == 0)
//    {
//        Console.WriteLine("Duzgun reqem daxil edin ");
//    }
//    else if (num1 == 1)
//    {
//        Console.WriteLine("Eded ne murekkebdir ne sade");
//    }
//    if (num1< 0)
//    {
//        Console.WriteLine("duzgun reqem daxil edin");
//    }
//    for (int i = 1; i < num1; i++)
//    {
//        if (num1%i == 0)
//        {
//            count++;
//        }
//    }

//    if (count >=2)
//    {
//        Console.WriteLine("Eded Murekkebdir");
//    }
//    else
//    {

//        Console.WriteLine("Eded sadedir");
//    }
//}
//SimpleOrNot(17);
//}
//SimpleOrNot(0);
#endregion




#region Task10
//n ededinin faktorialini hesablamaq.

//static void Factorial(int n)
//{
//    int hasil = 1;
//    for (int i = 1; i < n; i++)
//    {
//        hasil = hasil * i;
//    }
//    Console.WriteLine(hasil);
//}
//Factorial(5);
#endregion


