
using Jackyfei.Application.Constracts;

namespace Jackyfei.Application
{
    public class Boy : IPerson
    {
        private string _name { get; }

        public Boy(string name)
        {
            _name = name;
        }

        public void SayHello()
        {
            Console.WriteLine($"{_name}I am a Boy");
        }

    }
}
