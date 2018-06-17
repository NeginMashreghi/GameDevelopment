# Game Development

## Game Backstory

Jack is a person who has been struggling with understanding the benefits of healthy eating habits, so in order to actually understand it, Jack has to eat/catch all healthy foods on his way and avoid the temptations of the delicious. For Jack healthy foods to truly understand the importance of a healthy nutrition. 

This game provides users a fun way to count healthy points and learn about healthy food selections!
Game Mechanics 

**Scoring System**: Healthy points increase on collision with healthy foods and decrease of healthy points on collision with unhealthy foods.

**Mobility**: Player’s ability to move their character sideways to position it according to the foods coming in the opposite direction (vertically).

**Randomizers**: Sequence in which the foods are displayed and positioned within the game scene. 
In this game, the player “Jack” will move horizontally and will have to catch the healthy foods in order to get healthy points and avoid the unhealthy foods to not be able to lose the game. Foods are coming in the player’s direction (vertically down).


## High Level Description

In this game, the player “Jack” will move horizontally and will have to catch the healthy foods in order to get healthy points and avoid the unhealthy foods to not be able to lose the game. Foods are coming in the player’s direction (vertically down).

**First Level**: Player starts with 400 healthy (points). If they are able to catch (collide) healthy foods, healthy points will increase accordingly and once they reach 1000 points, player moves to the next level. If the player collides with the enemy (unhealthy foods), Unhealthy numbers will decrease. If the player reaches 0 points, game is over. 

**Second Level**: Player starts with 300 points and their new limit is to reach 2000 healthy points. If the player reaches the healthy points limit, they will move to the next level. If the player reaches the 0 points, game is over. 

**Third Level**: Player starts with 200 healthy points and their new limit is 3000 healthy points. If the player reaches the healthy point limit, they will move to the next level. If the player reaches the 0 points, game is over.
Screens’ Layout


## How It works


When the game is started player will see Main Scene that only have one type of UI
	•	Start button: When they click on the “Start” button the game will start on level one. 


When the player click on the start button they will see First Level Scene. In the first level scene you can see
	•	Jack (Avatar) 
	•	3 healthy food 
	•	3 unhealthy food
	•	“Level 1” label 
	•	“Health point: 400” label 

At the end of Level 1 If player reaches the 0 health point
	•	“You lost” label appears
	•	“Play again” button appears: if the player click on the “Play again” button the player will start the game from the beginning of the level 1.

If player gets 1000 point they will move to the Second Level Scene. In the second level scene you can see
	•	Jack (Avatar) 
	•	2 healthy food 
	•	4 unhealthy food
	•	“Level 2” label 
	•	“Health point: 300” label 



At the end of Level 2 If player reaches the 0 health point
	•	“You lost” label 
	•	“Play again” button appears: If the player click on the “Play again” button the player will start the game from the beginning of the level 1.



 If player gets 2000 point they will move to the Third Level Scene. In the third level scene you can see
	•	Jack (Avatar) 
	•	1 healthy food 
	•	5 unhealthy food
	•	“Level 3” label 
	•	“Health point: 200” label 





 At the end of Level 3 If player reaches the 0 health point
	•	“You Lost” label 
	•	“Play Again” button appears: If the player click on the “Play again” button the player will start the game from the beginning of the level 1.





If player gets 3000 point they will Last Scene. In this scene player can see
	•	“You Win” label 
	•	“Play Again” button appears: If the player click on the “Play again” button the player go to the Main Scene screen to start the game from the beginning.








![photo_2017-11-03_16-54-10](https://user-images.githubusercontent.com/27638465/41511298-4bb0d134-7242-11e8-8e0c-297ec3c85fd6.jpg)
![photo_2017-11-03_16-46-37](https://user-images.githubusercontent.com/27638465/41511303-53964528-7242-11e8-90ba-04d9e516a967.jpg)
![photo_2017-11-03_16-46-32](https://user-images.githubusercontent.com/27638465/41511305-57281fc2-7242-11e8-87c4-4aa366638118.jpg)
![photo_2017-11-03_16-40-55](https://user-images.githubusercontent.com/27638465/41511308-59bb052e-7242-11e8-8721-74abc932a761.jpg)
![photo_2017-11-03_16-40-44](https://user-images.githubusercontent.com/27638465/41511311-5c2d853e-7242-11e8-8bc0-eaa92998d7b7.jpg)
![photo_2017-11-03_16-30-14](https://user-images.githubusercontent.com/27638465/41511312-5e60e558-7242-11e8-87ee-10780c370d9d.jpg)
![photo_2017-11-03_16-26-49](https://user-images.githubusercontent.com/27638465/41511313-6069167c-7242-11e8-8dae-f7f7c105ab96.jpg)
![photo_2017-11-03_16-23-43](https://user-images.githubusercontent.com/27638465/41511314-62a0239a-7242-11e8-8882-0bf5772aa293.jpg)
![photo_2017-11-03_15-58-11](https://user-images.githubusercontent.com/27638465/41511316-6562b8d6-7242-11e8-93a8-b66e114dd174.jpg)



## Game Assets 

In our asset we will five folders 
- Texture 
- Audio
- Prefabs
- Script
  
### **Texture**

In this folder you will see two types of Texture 

1. Jack (Avatar)

   - The player can move the Jack (avatar) with right and left keyboard controller arrows 
   - The avatar is always on the bottom of the screen it cannot go up and down 

<img src="https://user-images.githubusercontent.com/27638465/41511297-490e5af0-7242-11e8-9cdd-ecaed39c7eb6.jpg" width="200" height="200" />



2. Foods

    - Foods move from top to bottom of the screen in different speed 
    - Food will appear on the screen randomly
    - They will be two type of food 
	
      1. Healthy 
          - Pear: 100 point
          - Peach: 200 point
          - Eggplant: 300 point 
      2. Unhealthy 
          - Sausage: -10 point
          - Stake: -40 point
          - Chocolate: -30 point
	  
<img src="https://user-images.githubusercontent.com/27638465/41511295-4635b49a-7242-11e8-9652-5750c76b19e2.jpg" width="400" height="200" />	  

<img src="https://user-images.githubusercontent.com/27638465/41511294-41abdc9c-7242-11e8-8631-f567752d0b73.jpg" width="400" height="200" />
	  


### **Audio**

There will be 3 sounds in this folder 

  - Background sound 
  - Interacting with healthy food sound
  - Interacting with unhealthy food sound


### **Script**

We will have estimated 5 script classes 
  - HealthyFoodController
  - UnHealthyFoodController
  - AvatarController
  - GameController
  - AvatarCollision 


