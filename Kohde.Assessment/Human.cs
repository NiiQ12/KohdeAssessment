namespace Kohde.Assessment {
    public class Human : Mammal {
        public string Gender { get; set; }

        public Human() { }

        public Human(string name, int age, string gender) : base(name, age) {
            Gender = gender;
        }

        public override string GetDetails() {
            return $"{base.GetDetails()}, Gender: {Gender}";
        }

        // Added in order for TestA3 to pass; however, I would argue that ToString() is sufficient to be overridden on the base class
        public override string ToString() {
            return GetDetails();
        }
    }
}