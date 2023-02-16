using System.Security.Cryptography.X509Certificates;

namespace GitCheckpoint1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");
            NewMessage();
            NewCalculation(10);
        }
        static void NewMessage()
        {
            CheckTest checkTest = new CheckTest();
            Console.WriteLine(checkTest.TestMessage());
            
        }
        static void NewCalculation(int c)
        {
            Calculate calculate = new Calculate(c);
            Console.WriteLine(calculate.Z+2+4);
        }
    }
}