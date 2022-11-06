/*int b = 1;
for (int i = 1; i <= 10; i++)
{
    b = b * i;
  
    Console.WriteLine(b);
}*/






/*int m = 10;
for (int i = 0; i <= m; i++)
{
    var a = i * (m + 1) / 2;
    
    Console.WriteLine(a);
   
}
*/


int a = 24;
int b = 1;
for (int i = 0; i <= a; i++)
{



    if (a % 2 == 0)
    {
      
        Console.WriteLine(a);
        a /= 2;
        b--;
    }
    else
    {
        Console.WriteLine("2nin quvveti deyik");
        break;
    }
 }
