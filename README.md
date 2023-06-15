# Hangman

A console-based word guessing game where the player tries to guess a hidden word by guessing individual letters.

Code Explanation

The chosen word is randomly selected from a predefined word list.
The game keeps track of the number of lives (attempts) remaining for the player.
The display variable is as StringBuilder that represents the current state of the word, with underscores for unrevealed letters.
The StagesArt is used to display the hangman art based on the remaining lives.
The game loop continues until the endOfGame is set to true.
Within the loop, the player is prompted to guess a letter, and the guess is processed.
If the guessed letter is already present in the display, a message is displayed.
If the guessed letter is not in the chosen word, the player loses a life and the hangman art is displayed accordingly.
The loop checks if the player has won by determining if there are any remaining underscores in the display.
If the player wins or loses, the appropriate message is displayed, and the game ends.
