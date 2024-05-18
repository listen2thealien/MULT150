/*

 ██████╗  █████╗ ███╗   ███╗███████╗     ██████╗██████╗ ██╗████████╗██╗ ██████╗
██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔════╝██╔══██╗██║╚══██╔══╝██║██╔════╝
██║  ███╗███████║██╔████╔██║█████╗      ██║     ██████╔╝██║   ██║   ██║██║     
██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║     ██╔══██╗██║   ██║   ██║██║     
╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╗██║  ██║██║   ██║   ██║╚██████╗
 ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝╚═╝  ╚═╝╚═╝   ╚═╝   ╚═╝ ╚═════╝

Answers to questions:

1. The game is too easy because Power-ups and Obstacles spawn frequently. 
You're able to miss a bunch and still succeed. Also, you're able to make
it 10-17 seconds without moving your character.

2. To make the game harder I would first decrease the frequency of Power-ups 
spawning. Then, increase the frequency of Obstacles spawning.

3. Creating a dynamic background and differing levels would help make the game 
become much more interesting. Dynamic background as in moving objects above and 
around the main playing area. Differing levels as in each level becomes more dif-
ficult by the addition of new obstacles and fewer Power-ups. Also, an end goal time
would help make the game more structured and goal oriented. For example, when the
time reaches 1 minute (and you are still alive), the game automatically loads the 
next, and more difficult level.

4 & 5. Moving the character and grabbing Power-Ups is fun. While not having an end goal 
and also having the timer go on forever makes the game tedious.

Changes made:

obstacle pickups:

-Mesh, from Cube to "Shape2" (custom mesh)
-Material, from red to "slime" (textured material)
-Collider, from Box Collider to Mesh Collider

Power-up pickups:

-Mesh, from Sphere to Capsule
-Material, from yellow to emissive light blue with custom texture
-Light, from yellow to light blue

(Particle System Change):

-Start Color, yellow to light blue

*/