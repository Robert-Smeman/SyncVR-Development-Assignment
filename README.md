# SyncVR-Development-Assignment

PC BUILD
In the folder SyncVR Build you can find and start the SyncVR Development Assignment .exe on a PC
It has 2 examples that use the Fibonacci sequence.
The first shows the next number of the sequence when you press the next  number button. To reset the numbers click the reset button.
You can go  to the next example by clicking on the next button.
Here you can click on the spawn button to spawn cubes, they will delete themself after a few seconds.
To go back to the previous example click on the return button.


ANDROID BUILD
Unfortunatley there is not an apk file for Aandroid phone, I had an error saying Gradle build failed. I tried fixing it for a multiple hours but could not get any solution to work out for me.
When working on the assignment I play tested by connecting my phone with Unity Remote 5 app. My phone is a Galaxy A51 with screen resolution of 1080 2400. I used this resolution in the editor aswel, so  thisway it could possibly still be checked on an Android phone


PROJECT IN UNITY
In the asset folder in Unity there are multiple other folders.
Interface and item sounds: This contains the sounds from an asset i downloaded.
Materials: contains the materials used on the walls and cube.
Prefabs: contains the cube that is being spawned.
Scene: contains the scene with the assignment.
Scripts: contains the scripts i made and use.


SCRIPTS
DestroySelfOverTime
Attached to the cube prefab
Has a function to delete the cube over time after it is spawned.

FibonacciCanvas
Attached to Manager
Has a function that displays the Fibonacci numbers and updates them to the next numbers of the sequence.
Has a reset function to set the numbers back to original.

NextExample
Attached to the Next_Fibonnaci_Button and Return_Fibonacci_Button
Has a function to move to the next example.
Has a function to move back to the previous example.

PlayAudio
Attached to the Main Camera
Has functions to play all the sounds that are being used for their corresponding button.

SpawnFibonnacciCube
Attached to Manager
Function to spawn cubes based on the number of the Fibonnaci sequence.

