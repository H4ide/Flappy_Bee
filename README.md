# Flappy Bee

Flappy Bee is a fun and challenging game where you navigate a bee through a series of pipes without hitting them. The game is built using Windows Forms and offers a simple yet addictive gameplay experience.

## Game Objective

The objective of Flappy Bee is to navigate a bee through a series of pipes without hitting them. Your goal is to achieve the highest score possible by successfully passing through the gaps between the pipes.

## Gameplay

- **Starting the Game:** Press the spacebar key to start the game. After a short delay, the game will begin, and you will control the bee's movement.
- **Controls:**
  - **Press the spacebar:** The bee will flap its wings and ascend briefly.
  - **Release the spacebar:** The bee will descend automatically.
  
- **Scoring:**
  - Each time you successfully pass through a set of pipes without hitting them, you will score one point.
  - The score is displayed on the screen and increases as you navigate through more pipes.

- **Lives and Invincibility:**
  - At the beginning of the game, you have three lives.
  - If you collide with a pipe, you will lose one life but gain one second of invincibility, during which the bee cannot be harmed.
  - Once all three lives are lost, the game will end.

- **Restarting the Game:**
  - To restart the game after it ends, press the spacebar. This will initiate a new gameplay session, and you can attempt to achieve a higher score.

## Technical Details

### Main Classes

- **Program Class:** 
  - Entry point of the application. Contains the `Main()` method.

- **Layer Class:** 
  - Represents a visual background layer in the game.
  - Methods include `layerReset()` and `SetLayerPosition()`.

- **ScoreManager Class:**
  - Manages the player's score and the maximum score achieved.
  - Methods include `LoadMaxScore()` and `UpdateMaxScore()`.

### WinForm Objects

- `PictureBox` objects for game elements like pipes, bee, ground, and hearts.
- `Label` objects for displaying score and game over messages.
- `Timer` objects for game and bird movement.

### Form1 Class

- Inherits from the `Form` class and represents the main form of the application.
- Handles game logic, event handlers, and rendering.
- Key methods include `gameTimerEvent()`, `BirdTick()`, `endgame()`, and `RestartGame()`.

## Ideas for Future Improvements

- Increase lives by 1 for every n pipes passed.
- Implement start and pause buttons, and a main menu.
- Add sounds for collisions and jumps.
- Smooth rotation of the bee based on velocity.

## Known Bugs (Features)

- The bee jumps strangely on the floor if you don't press the space bar.
- The bee starts with some delay or freezing.

## Getting Started

1. Clone the repository:
    ```bash
    git clone https://github.com/h4ide/FlappyBee.git
    ```

2. Open the project in Visual Studio.

3. Build and run the project.



## License

This project is licensed under the MIT License.

## Contacts

Author: Iurii Koshelenko
[email](koshelenkoyura@gmail.com)
Design by: [Olena Kazakova](elenkakuki@gmail.com)

---

Enjoy playing Flappy Bee!
