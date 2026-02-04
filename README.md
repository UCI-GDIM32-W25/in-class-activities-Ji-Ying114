# W1
## Activity 1
- Try to figure out the problems you encounter by yourself first before turning to LA's or generative Ai.
- Read pre-learning slides carefully
- Do not do your homework at the very last day
## Activity 2
1. 10
2. 2
3. The first method calls the second method and the second method prints "hello world" in the log.
4. MonoBehaviour
5. Debug.Log("x = 10");
6. 1. Argument: passing a value to the parameter
    2. Parameter: sth to the output
7. It should be the _playerTransform (the instance) used instead of Transform (the static method)
8. _playerTransform
## Activity 3
- [Allen Gu' s MG1 break-down doc](https://docs.google.com/document/d/1y5LOXHts-EvqE00ku0UjBCC5AgohWl3lteMNVPOctuo/edit?pli=1&tab=t.0)

# W2
## Activity 1
![break-down](image-1.png)
## Activity 2
[Allen Gu' s MG2 Commit](https://github.com/UCI-GDIM32-W25/mg2-Ji-Ying114/commits/main/)
I have completed the whole game.

# W3
## Activity 0-2
Partner name: Yaokun Wan
## Activity 3
![MG3 Break-down](image.png)
1. The finite state machine can posess the pigeons with different status based on the distance between the transform of pigeon and that of the player. The finite state machine contains 3 statuses. 
2. There are two different types of pigeons, having different sprites and reactions when the finite state machine indicates the status of close. There can be a parent class of pigeon and two respective child classes, so that the child classes can inherit some of the methods so that I dont have to write them repatatively, and I can make the code structure more organized. 

# W4
## Activity 1
All the locators are destroyed and only one is left. This is because the code in Awake() destroying the locator if there is already one. 
## Activity 2
![MG4 Break-down](image-2.png)
## Activity 3
I have completed the whole game.
[Allen Gu' s MG4 Commit](https://github.com/Ji-Ying114/HW4)

# W5
## Activity 1
I think that the interfaces and abstract classes can make the code more maintainable and structured because they are like the frame for certain classes. Once the frame is built, it will be more convinient to build everything else. I think whether changing my codes or not in these projects depends, since some games are not that big and the original frame just works, but principally I think I should change it because it makes the game structure more maintainable so that the further  coding will be much easier. 
## Activity 2
In W5_Demo2, EnemyStats and ItemW5Demo2 are model, EnemyW5Demo2 and PlayerW5Demo2 are controller and DialogueBubble and InventoryUI are view. 
## Activity 3
1. I think that there should be a scriptableobject that stores all the data needed for the beat. There should be multiple child classes inheriting from the parent class but with different input logics. There should be a singleton that tracks the current game status (eg scores)
2. I think that thre should be a scriptableobject that stores the animations and stats, an abstract parent class and multiple interfaces that store modes of attack and movements.
3. I think that there should be an abstract parent class with two child classes which are plant and rock. There should be interfaces, which are destroyable and plantable.There should be a scriptableobject that stores the animations.  
## Activity 4
1. Attendance: Allen Gu, Pengcheng Qi, Haoyi Zhang
2. [Draft Document](https://docs.google.com/document/d/1x9D6Q_2PD2IP5_ACEah36JJO2HM0rF6mYcNEO8_yNTk/edit?tab=t.0)