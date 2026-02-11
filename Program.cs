using ConsoleAppTraditional.Class;

namespace ConsoleAppTraditional
{
    
    class Program
    {

        static async Task Main(string[] args)
        {
            var outer = new Outer();
            outer.UseInner();
        }
    }
}
