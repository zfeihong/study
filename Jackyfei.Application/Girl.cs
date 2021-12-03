
using Jackyfei.Application.Constracts;

namespace Jackyfei.Application
{
    public class Girl : IPerson
    {
        private string _name { get; }

        public Girl(string name)
        {
            _name = name;
        }
        public void SayHello()
        {
            Console.WriteLine($"{_name},我是Girl");
        }

        //public Girl()
        //{
        //}

        //public void SayHello()
        //{
        //    Console.WriteLine($"I am a Girl");
        //}

    }
}
