# AR_App_Unity

AR_App_Unity is an mobile application using different tools of Agmented Reality for three differents used. 
The first one is to try different furniture on a decoration to facilitate furniture choices and purchases.
The second one is to visualize in 3D, the different specific parts of a technical object like a engine. To help you to identife these element and understand it's behavious while you are working on the rela object.  
The third one is an agmented card game with display 3D models on cards.

This application is an AR demonstration project, running on Unity 2021.3.30f1 and based on the library ARFondation. LeanTouch and UI-Round-Corners.
It's needing ARCore library for android and ARKit for iOS.



https://github.com/gdubrasquetd/AR_App_Unity/assets/58482474/a99ed83c-1fb3-40e5-81ec-b84be99fa258


## Key Features

### 1. Furnitures For Interior Decoration

The first feature allows the user to preview different furnitures on his decoration. \n
It's facilitate furnishings by testing the size, the color and the position of furnitures.\n
The functionality is using ARPlaneManager from ARFondation to detect plane surfaces like a floor, a wall or a table for example.\n
The rotation of the objects is using the finger touch management of the LeanTouch library.\n

<img src="https://github.com/gdubrasquetd/AR_App_Unity/blob/main/FurnitureImage.jpg" width="170"/>

Buttons:\n
\n
1 : Reload the plane detection to detect new surfaces.\n
2 : Delete the last furniture.\n
3 : Delete all furniture.\n
4 : Horizontal scrolling zone with buttons to select a furniture to place.\n

### 2. Engine Visualization

The functionality is using basic ARSession from ARFondation and the LeanTouch for the finger touch management.\n
The user can zoom, rotate and move the engine and as well activate or not the view of precised components.\n

<img src="https://github.com/gdubrasquetd/AR_App_Unity/blob/main/EngineImage.jpg" width="170"/>

1 : Horizontal scrolling zone with buttons to show or to hide the corresponding piece.\n

### 3. 3D Card Game

Visualise 3D characters anchored on the top of cards game and interact with it.\n

<img src="https://github.com/gdubrasquetd/AR_App_Unity/blob/main/CardImage.jpg" width="170"/>

1 : Remove and reload all objects.\n
2 : Lock the rotate axis of all objects.\n

## Installation

Running on Unity 2021.3.30f1.\n
Create an AR project.\n
Switch the plateform of you build to android or iOS on player's settings.\n
Check if ARFondation and ARCore (android) or ARKit (iOS) packages are import.\n
Import the repository on the Unity project.\n

## Author

Guillaume Dubrasquet-Duval

## License

To complete
