namespace number_using_recursion
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Enter desired numbers: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            //checking for 0 from the user
            if (n == 0)
                Console.Write("0");
            else
                diplayNumbers(n);
        }
        // starting the recursion to display every number
        static void diplayNumbers(int n)
        {
            
            {
                if (n == 0)
                    return;
            }
            // removing the last number 
            diplayNumbers(n /10);
            // getting the remainder and printing with a space
            Console.Write( n % 10 + " ");

        }
    }
}
