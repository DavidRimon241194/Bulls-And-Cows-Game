# C# - Bulls and Cows Game 
 
## The game:
First, the player needs to choose several attempts to play (between 4 to 10) then the computer randomly selects a 4-colors from the bucket of 8 colors (Purple, Red, Lime, Aqua, Yellow, Maroon, Blue, and White), a color cannot appear twice.
At each stage, the player guesses the colors combination that the computer has chosen with the specific places. As a result, the computer gives him "feedback" on the guess. To win the game the player must improve the next guess until the guesses are determined correctly. If the player didn't succeed within the number of attempts, he lose.

## Scoring method:
A letter that appears in the same position in the sequence that the computer selected ("stamp") will receive a "black square" and a letter that appears in the sequence of the computer but not in the same position in the sequence ("hit") will receive a "yellow square". Note, the result does not show which of the letters received a "stamp" "Or" hit".
The result is always aligned to the left when the "black square" is always shown followed by the "yellow square".

## Design Choices:
#### Model (M) - Contains the current state of the game and logic for checking win or lose
#### View (V) - Contains the windows forms interface for interacting with the game
#### Controller (C) - Contains the interface between View and Model

## how it's really works:
![Bulls and Cows example](https://user-images.githubusercontent.com/86151424/151951606-ada49a51-9a32-4c8e-b90a-a1cad08dd3e6.gif)
