List<string> wordDatabase = new List<string>() { "apple", "banana", "cherry", "date", "elderberry" };
string chosenWord = ChooseRandomWord(wordDatabase);
// It is a convention to use single quotes for character literals
string hiddenWord = new string('_', chosenWord.Length);
List<char> guessedLetters = new List<char>();
int incorrectGuesses = 0;

Console.WriteLine("Welcome to hangman!");
Console.WriteLine("_______");
Console.WriteLine("|   |");
Console.WriteLine("|");
Console.WriteLine("|");
Console.WriteLine("|");

// The 'Contains' method checks if a specified value exists in a string or collection and returns a boolean value indicating its presence.
while (hiddenWord.Contains('_') && incorrectGuesses < 6)
{
    Console.WriteLine(hiddenWord);
    Console.Write("Guess a letter: ");
    char guess = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();

    if (guessedLetters.Contains(guess))
    {
        Console.WriteLine("You already guessed that letter.");
        continue;
    }
    
    if (!char.IsLetter(guess))
    {
        Console.WriteLine("Invalid input. Please enter a letter.");
        continue;
    }

    guessedLetters.Add(guess);

    if (chosenWord.Contains(guess))
    {
        for (int i = 0; i < chosenWord.Length; i++)
        {
            if (chosenWord[i] == guess)
            {
                // Replace the character at index 'i' in 'hiddenWord' with the guessed letter
                hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guess.ToString());
            }
        }
    }
    else
    {
        incorrectGuesses++;
        Console.WriteLine("Incorrect guess!");
        switch (incorrectGuesses)
        {
            case 1:
                Console.WriteLine("_______");
                Console.WriteLine("|   |");
                Console.WriteLine("|   O");
                Console.WriteLine("|");
                Console.WriteLine("|");
                break;
            case 2:
                Console.WriteLine("_______");
                Console.WriteLine("|   |");
                Console.WriteLine("|   O");
                Console.WriteLine("|   |");
                Console.WriteLine("|");
                break;
            case 3:
                Console.WriteLine("_______");
                Console.WriteLine("|   |");
                Console.WriteLine("|   O");
                Console.WriteLine("|  /|");
                Console.WriteLine("|");
                break;
            case 4:
                Console.WriteLine("_______");
                Console.WriteLine("|   |");
                Console.WriteLine("|   O");
                Console.WriteLine("|  /|\\");
                Console.WriteLine("|");
                break;
            case 5:
                Console.WriteLine("_______");
                Console.WriteLine("|   |");
                Console.WriteLine("|   O");
                Console.WriteLine("|  /|\\");
                Console.WriteLine("|  /");
                break;
            case 6:
                Console.WriteLine("_______");
                Console.WriteLine("|   |");
                Console.WriteLine("|   O");
                Console.WriteLine("|  /|\\");
                Console.WriteLine("|  / \\");
                break;
        }
    }

    Console.WriteLine($"Guessed letters: {string.Join(", ", guessedLetters)}");
}
if (hiddenWord.Contains('_'))
{
    Console.WriteLine($"You lose! The word was {chosenWord}.");
}
else
{
    Console.WriteLine($"You win! The word was {chosenWord}.");
}

static string ChooseRandomWord(List<string> wordDatabase)
{
    Random random = new Random();
    int randomNumber = random.Next(0, wordDatabase.Count);
    return wordDatabase[randomNumber];
}