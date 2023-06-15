using Hangman;
using System.Text;

Logo logo = new Logo();

HangmanWords hangmanWords = new HangmanWords();

StagesArt stagesArt = new StagesArt();

string[] _list = hangmanWords.wordList;

Random random = new Random();

string chosenWord = _list[random.Next(_list.Length)];

int wordLenght = chosenWord.Length;

bool endOfGame = false;

int lives = 6;

StringBuilder display = new StringBuilder();

foreach (var c in chosenWord)
{
    display.Append("_");
}

Console.WriteLine(logo.AsciiArt);

// For Testing code
Console.WriteLine(chosenWord);

Console.WriteLine(display);

while (!endOfGame)
{
    Console.WriteLine(stagesArt.Stages[lives]);
    Console.WriteLine("Guess a Letter: ");
    string guess = Console.ReadLine().ToLower();
    char charGuess = char.Parse(guess);

    if (display.ToString().Contains(guess))
        Console.WriteLine($"You have already guessed {guess}");

    for (int i = 0; i < wordLenght; i++)
    {
        char letter = chosenWord[i];
        if (letter == charGuess)
            display[i] = letter;
    }
        if (!chosenWord.Contains(guess))
        {
            lives -= 1;
            if (lives == 0)
            {
                Console.WriteLine("You lose.");
                Console.WriteLine(stagesArt.Stages[lives]);
                endOfGame = true;
            }
        }

        if (!display.ToString().Contains("_"))
        {
            Console.WriteLine("You win!");
            endOfGame = true;
        }
    Console.WriteLine(display);
}