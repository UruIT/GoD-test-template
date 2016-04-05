# Programming Assesment

The purpose of this exam is to provide a better understanding of your design, programming, and analysis skills. As with any programming project, you will need to balance de amount of time spent working againt the quality of the final result. We ask to not expend more than 3 calendar days.<br><br>
Please email a ZIP file with the solution and a readme file explaining if it is required to follow any aditional step to run the game. It would be great to run the solution directly from Visual Studio 2013 or 2015 without any additional step.
<br>
You have to use the following technologies:
        

+ AngularJS
+ ASP.NET MVC or Web Api

> You can add any library/framework and use the database you prefer.

# Specifications
In the "game of drones" there are 2 players trying to conquer each other.<br>
Players take turns to move, and moves are basically 3: Paper, Rock, Scissors. And just like the game “Paper, rock, scissors”, each move ¨kills¨ another move.<br><br>
Like so:

```            
<ul class="list-group">
    <li class="list-group-item">Paper beats Rock</li>
    <li class="list-group-item">Rock beats scissors</li>
    <li class="list-group-item">Scissors beat Paper</li>
</ul>
```
The first player to beat the other player 3 times, wins the battle.

## We would like you to create a web site with:

1. A Start button to begin the game
2. Players are asked for their names. (only 2 players)
3. The game beings and each player is asked to choose one of the 3 moves.
4. First it asks player1, then player2, and the systems computes the result of the play. (The game happens on the same computer for both players. It is not required to create a true online game. 2 players share the computer, and the system asks each player for their move assuming the other player looks away while the other selects the move)
5. this repeats until one of the players wins 3 times. This is the winner of the game.
6. the result of each round should be displayed somewhere in the screen… so that players know what´s the total score.
7. once a game is finished, the start button is displayed again so that a new game can be played.


## Additional features

The result of a game should be stored somewhere to keep track of games won by each player. So basically we would like to know how many games a player has won.
<br><br>
An important feature is to be possible to change the ¨moves¨ in runtime. This means that after a game completes, one could change the default move rules and have more moves added or change the way each move ¨kills¨ the other. We are interested in a simple solution easy to implement.
<br><br>
We do not encourage to use an XML file but to give an example to illustrate, a typical game could be described by the following xml file:
<br><br>
```
<moves>
    <paper kills="Rock" />
    <rock kills="Scissors" />
    <scissors kills="Paper" />
</moves>
```
But one could change that to:
<br><br>
```
<moves>
    <paper kills="Rock" />
    <rock kills="Scissors" />
    <scissors kills="String" />
    <string kills="Dog" />
    <dog kills="Paper" />
</moves>
```
In this scenario it could happen that no player wins a round.
<br>that case nothing happens and the game continues to the next round.
<br><br>
## Mocks
Here is a mock of each screen. You are free to modify the look and feel of the screen as you please.
<br><br>
To start a game, the system asks for the name of each player.
<br>
<img src="https://raw.githubusercontent.com/klewgenius/GoD-test-template/master/NET/Uruit.GameOfDrones/Uruit.GameOfDrones/Content/Images/pic1.png" width="350px"/><br>
The game starts with Round1. The system asks Player1 for a move. Replace [Player1 Name] with player’s name.
<br>
<img src="https://raw.githubusercontent.com/klewgenius/GoD-test-template/master/NET/Uruit.GameOfDrones/Uruit.GameOfDrones/Content/Images/pic3.png" width="250px"/><br>
After player 1 selects a move, then the system asks player 2 for a move (same round)
<br>
<img src="https://raw.githubusercontent.com/klewgenius/GoD-test-template/master/NET/Uruit.GameOfDrones/Uruit.GameOfDrones/Content/Images/pic4.png" width="250px"/><br>
Winners of each round are displayed somewhere on the screen. Here we see Round3, and to the right the score of the previous rounds:
<br>
<img src="https://raw.githubusercontent.com/klewgenius/GoD-test-template/master/NET/Uruit.GameOfDrones/Uruit.GameOfDrones/Content/Images/pic5.png" width="550px"/><br>
When a player reaches 3 wins, he is the winner, and the following screen displays:
<br>
<img src="https://raw.githubusercontent.com/klewgenius/GoD-test-template/master/NET/Uruit.GameOfDrones/Uruit.GameOfDrones/Content/Images/pic6.png" width="550px"/><br>
Clicking the Play Again button, the systems takes you to the first screen. 