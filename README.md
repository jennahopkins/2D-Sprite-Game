# Storm Dodgers

## Play the Game
**Unity Play Link**: https://play.unity.com/en/games/92e534b4-ea0d-49d3-b729-cd47977ab930/storm-dodgers-2d-sprite-flight

## Game Overview
Storm Dodgers is a simple game where the player is an airplane trying to dodge storm clouds. Storm clouds bump and bounce off of one another, changing direction quickly in the zero-gravity environment. The airplane must not touch any of the storm clouds or edges of the screen to stay alive for as long as they can. Try to beat your high score!

### Controls
- Left click in the direction you want to steer the airplane, hold to continue to apply boost
- Left click restart button to restart the game after you die

### How to Play
Left click and hold in the direction you want to steer the airplane, being careful to not hit any of the storm clouds or edges of the screen. If you do, the game is over, and a restart button will appear for you to try again.

## Base Game Implementation

### Completion Status
- [x] Player movement and controls
- [x] Obstacle spawning system
- [x] Collision detection
- [x] Score system
- [x] Game over state

### Known Bugs
- No known bugs in the base game

### Limitations
- Sprite colliders were impossible to make comletely fit my shapes/images, so the airplane and storm clouds might slighly 'go into each other' before bouncing away (especially on corners), though not very noticeably.
- Game was developed on 16:9 aspect ratio in Unity Editor, but when published to Unity Play it seems the width is larger and it shows the outside of my side borders. I'm not sure why this happened since it is supposed to be a fixed ratio, but the game is still fully functional.

## Extensions Implemented

### 1. Create a Cohesive Color Scheme (2 points)
**Implementation**: My color scheme was somewhat limited to the colors of the assets I downloaded, but I made the airplane, its explosion, and the restart button be the same color, the lighning bolt and particle effects for storm cloud collisions the same color, and the high score and score labels respective to the background and airplane colors.
**Game Impact**: Creating a cohesive color scheme makes the game more visually appealing, and gives users more of a story to play into rather than with a bunch of random colors. It will be more entertaining to users.
**Technical Details**: I used hex code 383D29 for the airplane, its particle effect, the background of the score label, and the restart button. I used hex code F4D114 for the lightning bolt and the storm cloud particle effects (like the electricity is sparking every time the clouds bounce against something). I used hex code 6F7CC3 for the sky background and the background of the high score label.
**Known Issues**: None

### 2. Change Your Entire Game Concept (3 points)
**Implementation**: I changed the game theme to be an airplane dodging storm clouds instead of a rocketship dodging hexagons. To do this, I used a diamond, square, and triangle sprites to make the shape of a cloud with a lightning bolt and free assets over the top to make them look more realistic. For the airplane, I used 3 capsule sprites to make the 2 wings and body of the airplane and again used a free asset over the top. I also added booster flames to the wings of the airplane instead of the back.
**Game Impact**: Changing the theme makes the game more visually appealing, and gives users more of a story to play into rather than just dodging hexagons. It will be more entertaining to users.
**Technical Details**: I used 2 booster flames for the airplane instead of the just one that was used for the rocketship. To do this, I had to reference a second booster flame at the top of my PlayerController.cs code and add code in the BoosterFlame() function to make both appear and disappear. I also had to connect the second booster flame to the airplane in the inspector window on Unity.
**Known Issues**: None

### 3. Swap Out Your Sprites (3 points)
**Implementation**: I added images to my sprite shapes through downloading them through the Unity Asset Store and OpenGameArt.org and making them childs of my Game Objects.
**Game Impact**: Adding sprite images makes the game more visually appealing, and gives users more of a story to play into rather than just dodging solid-colored shapes. It will be more entertaining to users.
**Technical Details**: I added the images to the scene as childs of my Game Objects for both the storm clouds and the airplane.
**Known Issues**: None

### 4. Destroy the Borders on Game Over (4 points)
**Implementation**: I turned the borders off on game over so that the storm clouds would fly off the screen.
**Game Impact**: This feature makes the game more visually appealing, and gives users more of a story to play into rather than just having the shapes stay there when the game is over. It will be more entertaining and realistic to users.
**Technical Details**: I created a reference to my Borders Game Object in my PlayerController.cs script, and connected them in the Inspector window. When the player dies, the borders are turned off (SetActive = false), allowing storm clouds to fly off the screen.
**Known Issues**: None

### 5. Add Ambient Background Particles (4 points)
**Implementation**: I added some background particles to the game to make it more exciting.
**Game Impact**: This feature makes the game more visually appealing, and gives users more of a story to play into rather than just having a plain background. It will be more entertaining to users.
**Technical Details**: I created a new particle effect in a sphere shape, made it slow moving and small (randomly generating), and set the color to the same color as the clouds. In this way, the particles will be a small detail in the background, not taking away from the main gameplay.
**Known Issues**: None

### 6. Increase Difficulty Over Time (5 points)
**Implementation**: I changed the bounciness of the physics of the storm clouds to make them gain velocity with each bounce and increase the difficulty of the game.
**Game Impact**: This feature makes the game more challenging, which makes the game more interesting to seasoned users who find it getting too easy for them and boring.
**Technical Details**: I increased the bounciness value of the Physics Material to 1.06 from 1.0, so the velocity would increase with each bounce. I chose not to cap the speed so that it can just keep becoming harder and harder to stay alive and not reach a standstill.
**Known Issues**: None

### 7. Add Sound Effects and Background Music (5 points)
**Implementation**: I added background music while the game is being played and an explosion sound effect when the player dies.
**Game Impact**: This feature makes the game more engaging and interesting to the player, as now they have a little toon to listen to as they play and an explosion sound when they die which makes it more realistic.
**Technical Details**: I downloaded free sfx assets and put the background music as its own, looping and having moderately low volume. The explosion sound I added as a component to the already existing explosion effect so that it would play when the explosion happened.
**Known Issues**: None

### 8. Animate the Booster Graphic with Audio (6 points)
**Implementation**: I added a booster graphic and audio that played when the mouse was clicked to represent the thrust of the engine.
**Game Impact**: This feature makes the game more engaging and interesting to the player, as now they have realistic sound and visual effects to go along with their gameplay.
**Technical Details**: I made two booster sprites to go on the wings of the airplane, and set them inactive to start. In my PlayerController.cs script, I made a BoosterFlame() function that tracked if the mouse was clicked or released, and toggled the booster flames objects accordingly. In the inspector, I added the sound effect to one of the flames so it would play when they were set active. I only put it on one because I didn't want the audio to have issues with two playing at the same time.
**Known Issues**: None


## Credits
- Lightning bolt images: "Fun Hyper Casual UI Pack - FREE" by Gelzo on Unity Asset Store
- Cloud and sky background images: "2D Platformer - Lovely Snowy" by HobiSoLoved on Unity Asset Store
- Airplane image: "2D Fighter Plane Template" by Saifex on OpenGameArt.org
- All sound effects from Unity Learn

## Reflection
**Total Points Claimed**: Base: 80% + Extensions: 32% = 112%
**Challenges**: The most difficult aspect of this project was overall becoming more familiar with Unity and C# specifically. Since there are so many options, it can be hard to figure out the right one and how to connect it with my code. The tutorials were very helpful, but when I was left to do things on my own (such as the particle systems and labels), I struggled a bit to find what I wanted. In C#, I had to learn new syntax and functions and remember how to use them for my Game Objects and references, which was also a challenge before I started to get the hang of it.
**Learning Outcomes**: I learned a lot more in depth of what all you can do with Unity, such as particle effects, colliders and rigid bodies, sprites, sound effects, how to add my own images, and more. I became much more familiar with C# and how it works with Unity as well.

## Development Notes
I tried to implement the flashing high score feature when there is a new high score, but struggled a lot and ended up giving up on it. I struggled with it because I wanted it to flash after the player dies if they beat their high score, but since the player Game Object is destroyed, it loses its reference to the UI. I figured out that I would probably have to put it in a separate script, but I already had all of the scoring logic in the PlayerController.cs script and wasn't sure how the importing and communication between the two scripts would work. So, I put it on the backburner as a future point of interest.