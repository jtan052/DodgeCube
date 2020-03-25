# DodgeCube
A Unity project called DodgeCube. The goal of which is to advance through levels by moving along a path and dodging obstacles. 


## The Game
That game itself is a practice in scripting player movement, camera following, physics materials, and collision detection. The green cube
is controlled by the player with WASD controls. Hitting a red block will reset the level after a short delay. Falling below a y-axis
threshhold will reset the level. Hitting a blue block will advance you to the next level.

The camera holds a script that attaches it to an offset from the player, angled down, in order to give the player a 3rd person view
of the game.

Red and blue blocks are coded to trigger collision events if they detect that the player has struck them. Either restarting the level
or triggering the transition scene to the next level.

Different physics material with varying frictions were tested in order to get the gliding-stop movement of the player with the floor.

The player (green cube) is coded to detect its y-axis should the player fall off the map - and reset the level. As well as to detect
WASD movement and apply an adjustable force on the cube with each frame of the game.

The score displayed at the top of the game is a text object linked to the player's z-axis and displays the players movement along the 
path.

You may try the game under DodgeCubeGame > Builds > Windows > x86 > Dodgecube.exe

Alternatively a video demonstration is available at https://youtu.be/A5Z338Z-DWk
