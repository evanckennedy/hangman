# Hangman Game in C#

This is a console-based word guessing game developed in C#. The game incorporates concepts of strings, iterations, and exception handling.

## Game Features

1. **Word Database**: The game includes a list of words related to fruits that the player will attempt to guess.

2. **Game Logic**: The game selects a random word from the word database and allows the player to guess a letter. It checks if the guessed letter is in the selected word and updates the display string with correctly guessed letters. The game tracks incorrect guesses and updates a hangman figure for each incorrect guess. The game continues until the player correctly guesses the word or reaches a maximum number of incorrect guesses.

3. **User Interface**: The game displays the current state of the word (with hidden letters and correctly guessed letters, using underscores for hidden letters). It displays a character bank of previously guessed letters. It also displays a hangman figure for incorrect guesses and prompts the player to enter a letter for their guess.

4. **String Manipulation**: The game uses string manipulation techniques to update the display string based on correct guesses.

5. **Iterations**: The game uses iterations to loop through the selected word to check for the presence of guessed letters.

6. **Exception Handling**: The game implements exception handling to validate user input for guessing a letter. It ensures that the input is a single letter and handles any potential errors.

7. **Game Over Handling**: When the game is over (either because the word is guessed or the player reaches the maximum incorrect guesses), it displays a message indicating the outcome and reveals the correct word.

## Main Program File

The main program file is `Program.cs`. This is where the game logic is implemented.

## How to Play

Run the program, and follow the prompts in the console. Good luck!
