namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
               
                Console.WriteLine("Input days attended: ");

              
                int days = Convert.ToInt32(Console.ReadLine());

                if (days < 10)
                {
                    Console.WriteLine("Not Eligible");
                }
                else if (days >= 10 && days <= 19)
                {
                    Console.WriteLine("Eligible");
                }
                else 
                {
                    Console.WriteLine("Excellent Attendance");
                }

                
                Console.ReadKey();
         
        }
    }
}
