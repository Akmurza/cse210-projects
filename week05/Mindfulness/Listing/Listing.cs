public class Listing : Activity{
    private List<string> _prompts = new List<string>
    {
        "What kind of people do you value?",
        "What are your strengths?",
        "Who have you helped this week?",
        "Who are your personal heroes?"
    };

        private string _prompt;

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            _prompt = _prompts[index];
            return _prompt;
        }

        public void DisplayPrompt()
        {
            Console.WriteLine(GetRandomPrompt());
        }

        public void StartExercise()
        {
            base.StartExercise();
            Console.Clear();
            Console.WriteLine("Listing Exercise: " + _prompt);
            Console.WriteLine("Take a moment to reflect on this prompt and write down your thoughts.");
            Console.WriteLine("Press Enter when you are ready to continue...");
            Console.ReadLine();

            Console.WriteLine("Your thoughts: ");
            string thoughts = Console.ReadLine();

            Console.WriteLine("Thank you for your listing!");
            EndExercise();
        
        }
}