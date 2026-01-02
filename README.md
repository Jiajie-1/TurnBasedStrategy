# Turn-Based Strategy Game Prototype

## Overview

This project is a small turn-based strategy game prototype developed in **C# (.NET)**.
 It focuses on **core game logic and system design**, rather than graphics or user interface.

The project was created as a portfolio piece for a **Game Programming MSc application**.

------

## Game Description

- Grid-based 2D game
- Player vs AI-controlled enemy
- Strict turn-based flow
- The game ends when either unit’s HP reaches zero

Combat is only allowed when two units are **orthogonally adjacent**.

------

## Key Concepts Demonstrated

- Turn-based game loop
- Finite state machine (`Start`, `PlayerTurn`, `EnemyTurn`, `GameOver`)
- Grid-based movement
- Rule-based combat validation
- Simple AI decision-making

------

## Project Structure

```
Game/        Game state and turn management
Grid/        Grid and position system
Entities/    Player and enemy units
Rules/       Movement and combat rules
AI/          Enemy decision logic
Program.cs   Entry point
```

The code is structured to clearly separate game logic, rules, and AI behaviour.

------

## What I Learned

- Designing state-driven turn systems
- Implementing rule-consistent movement and combat
- Structuring game code for clarity and maintainability
- Debugging logic inconsistencies between systems

------

## Technologies Used

- C#
- .NET 8
- Console Application
- Git & GitHub

------

## Academic Context

This prototype demonstrates fundamental game programming concepts suitable for postgraduate study.