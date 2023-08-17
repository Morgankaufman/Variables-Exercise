namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; // Declaration Syntax
            
            dogName = "Rex"; // Initialized === assigning a value

            int dogAge = 5; // Declaring and Initializing

            char firstInitial = 'R'; 

            bool isHungry = true;

            double dogWeight = 54.3;

            decimal dogHeight = 14.7m;

            Console.WriteLine($"Hello my dogs name is {dogName}, his initial is {firstInitial} he is {dogAge} years old");
            Console.WriteLine($"He weighs {dogWeight} pounds and he is {dogHeight} inches tall");
            Console.WriteLine($"It is {isHungry} he is always hungry");

        }
    }
}
