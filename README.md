# AR_App_Unity

AR_App_Unity is a mobile application using different tools of Augmented Reality for three differents used.  <br/>
The first one is to try different furniture on a decoration to facilitate furniture choices and purchases.  <br/>
The second one is to visualize in 3D, the different specific parts of a technical object like an engine. To help you to identife these element and understand its behaviour while you are working on the real object.   <br/>
The third one is an augmented card game with display 3D models on cards. <br/>

This application is an AR demonstration project, running on Unity and based on the library ARFondation. LeanTouch and UI-Round-Corners. <br/>


https://github.com/gdubrasquetd/AR_App_Unity/assets/58482474/a99ed83c-1fb3-40e5-81ec-b84be99fa258


## Key Features

### 1. Furnitures For Interior Decoration

The first feature allows the user to preview different furnitures on his decoration. <br/>
It's to facilitate furnishings by testing the size, the color and the position of furnitures. <br/>
The functionality is using ARPlaneManager from ARFondation to detect plane surfaces like a floor, a wall or a table for example. <br/>
The rotation of the objects is using the finger touch management of the LeanTouch library. <br/>

<img src="https://github.com/gdubrasquetd/AR_App_Unity/blob/main/FurnitureImage.jpg" width="170"/>

Buttons: <br/>

1 : Reload the plane detection to detect new surfaces. <br/>
2 : Delete the last furniture. <br/>
3 : Delete all furniture. <br/>
4 : Horizontal scrolling zone with buttons to select a furniture to place. <br/>

### 2. Engine Visualization

The functionality is using basic ARSession from ARFondation and the LeanTouch for the finger touch management. <br/>
The user can zoom, rotate and move the engine and as well activate or not the view of precised components. <br/>
It help the user to identife these elements and understand its behaviour while he is working on it.

<img src="https://github.com/gdubrasquetd/AR_App_Unity/blob/main/EngineImage.jpg" width="170"/>

Buttons: <br/>

1 : Horizontal scrolling zone with buttons to show or to hide the corresponding piece. <br/>

### 3. 3D Card Game

Visualise 3D characters anchored on the top of card game and interact with it. <br/>

<img src="https://github.com/gdubrasquetd/AR_App_Unity/blob/main/CardImage.jpg" width="170"/>

Buttons: <br/>

1 : Remove and reload all objects. <br/>
2 : Lock the rotate axis of all objects. <br/>

## Installation

Running on Unity 2021.3.30f1. <br/>
Create an AR project. <br/>
Switch the platform of you build to android or iOS on player's settings. <br/>
Check if ARFondation and ARCore (android) or ARKit (iOS) packages are import. <br/>
Import the repository on the Unity project. <br/>

## Author

Guillaume Dubrasquet-Duval

## License

To complete
