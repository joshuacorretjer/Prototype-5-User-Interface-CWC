# Prototype 5 – User Interface

## Overview

A Unity 3D arcade-style reflex game developed as part of the **Create with Code Live – Spring 2020** course. The objective is to click and destroy objects launched into the air before they fall off the screen, while avoiding harmful targets.

The project focuses on implementing a complete user interface and gameplay experience, including a title screen, difficulty selection, score tracking, and a game-over screen. It introduces UI development with TextMeshPro, game state management, event listeners, scene management, and communication between gameplay and UI scripts.

## Features

- **Target Interaction:** Implemented mouse-click interactions to destroy objects before they fall off the screen.
- **Randomized Object Spawning:** Created a spawning system that launches different objects into the air with randomized rotation and torque.
- **Score System:** Implemented score tracking that updates dynamically when targets are successfully clicked.
- **Title Screen:** Created a main menu with difficulty selection options.
- **Difficulty Settings:** Added multiple difficulty levels that adjust the object spawning rate to increase the game's challenge.
- **Game Over System:** Implemented game-over conditions when a required target falls without being destroyed.
- **Restart Functionality:** Added a UI button that reloads the gameplay scene, allowing players to try again without restarting the application.
- **Dynamic UI:** Implemented UI elements that appear and disappear depending on the current game state.

## What I Learned & Implemented

### Gameplay Mechanics and Object Spawning
- Switched the Scene view from 3D to 2D to work with a different gameplay perspective.
- Used `Rigidbody.AddTorque()` to apply randomized rotational forces to flying objects.
- Created a GameManager to coordinate game states, score management, and object spawning.
- Used `List<GameObject>` collections to organize good and bad target objects.
- Retrieved the number of elements in collections using the `.Count` property.
- Implemented coroutines using `IEnumerator` to control object spawning over time.
- Used `while` loops to repeatedly execute spawning logic while gameplay conditions remained valid.
- Used `OnMouseDown()` to detect mouse clicks on target objects and destroy them.

### User Interface Development
- Created UI elements using Unity's Canvas system and TextMeshPro.
- Configured the Game view to a 16:9 aspect ratio when designing the interface.
- Used UI anchors to position and maintain interface elements relative to the Canvas.
- Organized UI elements into parent GameObjects to create menus, HUDs, and other interface sections.
- Implemented dynamic UI visibility using `GameObject.SetActive()` to show and hide interface elements depending on game states.

### Score System and Script Communication
- Created an `UpdateScore(int)` method to update the player's score.
- Implemented script communication between target objects and the GameManager to update the score when targets were clicked.
- Connected gameplay events to UI updates, ensuring that the displayed score reflected the current game state.
- Used boolean variables and game state management to prevent score updates and additional object spawning after the game ended.

### Menus, Difficulty Selection, and Scene Management
- Created a title screen with difficulty selection buttons.
- Added button listeners to detect player selections and trigger the corresponding game-start functions.
- Implemented a `StartGame()` function that accepts a difficulty parameter to configure gameplay settings.
- Adjusted the object spawning rate based on the selected difficulty, increasing the challenge at higher levels.
- Created a Game Over screen that activates when a required target falls without being destroyed.
- Used `SceneManager.LoadScene()` to reload the gameplay scene when the player selects the restart button.

## Technologies & Tools

- **Game Engine:** Unity
- **Programming Language:** C#
- **IDE:** Visual Studio
- **UI:** Unity Canvas, TextMeshPro, UI Buttons
- **Concepts:** User Interface Development, GameManager, Game State Management, Coroutines, Object Spawning, Rigidbody Physics, AddTorque, Mouse Input, Lists, Score Systems, Script Communication, Event Listeners, Difficulty Settings, Scene Management

## Course

**Create with Code Live – Spring 2020**

A remote Unity course taught by professionals working at Unity, focused on learning game development and programming through hands-on projects.
