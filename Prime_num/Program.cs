class prime 
{
    static void Main(string[] args)
    {
        int c = 0; int n1; int i; int r;
        System.Console.WriteLine("Enter any number");
        n1 = int.Parse(System.Console.ReadLine());
        if (n1 == 0 || n1 == 1)
        {
            System.Console.WriteLine("Not Prime Number");

        }
        else
        {
            for (i = 2; i <= n1 / 2; i++)
            {
                r = n1 % i;
                if (r == 0)
                    c++;
            }
                if (c != 2)
                {
                    System.Console.WriteLine("This is Prime Number");
                }
            else
            {
                System.Console.WriteLine("Not Prime Number");
            }
            
                



            













        }
    }

}