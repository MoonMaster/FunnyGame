<h1> Funny Game </h1> <img src="https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva?svg=true" alt="Project Badge" width="300">

This game is designed to verify the correctness of the approval of the law of Bonford (https://en.wikipedia.org/wiki/Benford's_law). This law states that the probability that the number will start at the digit 1,2 or 3 is much larger than the appearance of other figures.

## Rule of Game

You are playing against the computer. First you need to specify the player's name. The player's name must necessarily start with a capital letter and do not have numbers. Next, you must select the set of numbers that you choose as the winning ones. You think of a number and a computer, too. The program takes two numbers multiplies them and takes the first digit. If the first digit is included in your set.

## Features of the game

You can play this game in two modes: console and graphical (WPF).

## Used methods:

At this stage, the game logic is implemented in the console mode when using the MVС pattern. In graphical mode, the MVМM pattern is used.

## What is planned to be completed:
1. Make a mechanism for collecting statistics in both the console mode and in the graphical mode. Implement statistics output, regardless of how many games were discontinued.
2. Finalize the mechanism for logging the game.
3. Finalize the algorithmic part. It is necessary to make sure that the use of code in the console mode is easily superimposed on the graphical mode without significant transformations.
4. Cover the game with tests. Coverage should be at least 80% of the code.
