# [Storm Dodgers]

## Play the Game
**Unity Play Link**: [Your Unity Play URL]

## Game Overview
Storm Dodgers is a simple game where the player is an airplane trying to dodge storm clouds. Storm clouds bump and bounce off of one another, changing direction quickly in the zero-gravity environment. The airplane must not touch any of the storm clouds or edges of the screen to stay alive for as long as they can. Try to beat your high score!

### Controls
- Left click in the direction you want to steer the airplane

### How to Play
Left click in the direction you want to steer the airplane, being careful to not hit any of the storm clouds or edges of the screen. If you do, the game is over, and a restart button will appear for you to try again.

## Base Game Implementation

### Completion Status
- [x] Player movement and controls
- [x] Obstacle spawning system
- [x] Collision detection
- [x] Score system
- [x] Game over state

### Known Bugs
- [List any bugs in base game]

### Limitations
- Sprite colliders were impossible to make comletely fit my shapes/images, so the airplane and storm clouds might slighly 'go into each other' before bouncing away (especially on corners), though not very noticeably.

## Extensions Implemented

### 1. Create a Cohesive Color Scheme (2 points)
**Implementation**: My color scheme was somewhat limited to the colors of the assets I downloaded, but I made the airplane, its explosion, and the restart button be the same color, the lighning bolt and particle effects for storm cloud collisions the same color, and the high score and score labels respective to the background and airplane colors.
**Game Impact**: Creating a cohesive color scheme makes the game more visually appealing, and gives users more of a story to play into rather than with a bunch of random colors. It will be more entertaining to users.
**Technical Details**: I used hex code 383D29 for the airplane, its particle effect, the background of the score label, and the restart button. I used hex code F4D114 for the lightning bolt and the storm cloud particle effects (like the electricity is sparking every time the clouds bounce against something). I used hex code 6F7CC3 for the sky background and the background of the high score label.
**Known Issues**: [Any bugs specific to this extension]

### 2. Change Your Entire Game Concept (3 points)
**Implementation**: I changed the game theme to be an airplane dodging storm clouds instead of a rocketship dodging hexagons. To do this, I used a diamond, square, and triangle sprites to make the shape of a cloud with a lightning bolt and free assets over the top to make them look more realistic. For the airplane, I used 3 capsule sprites to make the 2 wings and body of the airplane and again used a free asset over the top. I also added booster flames to the wings of the airplane instead of the back.
**Game Impact**: Changing the theme makes the game more visually appealing, and gives users more of a story to play into rather than just dodging hexagons. It will be more entertaining to users.
**Technical Details**: I used 2 booster flames for the airplane instead of the just one that was used for the rocketship. To do this, I had to reference a second booster flame at the top of my PlayerController.cs code and add code in the BoosterFlame() function to make both appear and disappear. I also had to connect the second booster flame to the airplane in the inspector window on Unity.
**Known Issues**: [Any bugs specific to this extension]

### 3. Swap Out Your Sprites (3 points)
**Implementation**: I added images to my sprite shapes through downloading them through the Unity Asset Store and OpenGameArt.org and making them childs of my Game Objects.
**Game Impact**: Adding sprite images makes the game more visually appealing, and gives users more of a story to play into rather than just dodging solid-colored shapes. It will be more entertaining to users.
**Technical Details**: I added the images to the scene as childs of my Game Objects for both the storm clouds and the airplane.
**Known Issues**: [Any bugs specific to this extension]


## Credits
- Lightning bolt images: "Fun Hyper Casual UI Pack - FREE" by Gelzo on Unity Asset Store
- Cloud and sky background images: "2D Platformer - Lovely Snowy" by HobiSoLoved on Unity Asset Store
- Airplane image: "2D Fighter Plane Template" by Saifex on OpenGameArt.org

## Reflection
**Total Points Claimed**: [Base: 80% + Extensions: X% = Total%]
**Challenges**: [What was difficult]
**Learning Outcomes**: [What you learned]

## Development Notes
[Any additional notes about your development process]