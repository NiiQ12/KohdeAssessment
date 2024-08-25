namespace Kohde.Assessment {
    public class Cat : Mammal {
        public string Food { get; set; }

        public Cat() { }

        public Cat(string name, int age, string food) : base(name, age) {
            Food = food;
        }

        public override string GetDetails() {
            return $"{base.GetDetails()}, Food: {Food}";
        }
    }
}