using System;

namespace Kohde.Assessment
{
    // Implements IDisposable to accommodate Assessment D
    public class Dog : Mammal, IDisposable
    {
        public string Food { get; set; }

        public Dog() { }

        public Dog(string name, int age, string food) : base(name, age) {
            Food = food;
        }

        public override string GetDetails() {
            return $"{base.GetDetails()}, Food: {Food}";
        }

        public void Dispose() {
            Console.WriteLine("Disposed of dog");
        }
    }
}