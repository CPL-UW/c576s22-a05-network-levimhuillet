# CS576-Tetris-Sample

1. Clone this repo
2. Open it in a 2021 version of Unity
3. 2xClick TetrisScene (in Assets/Scenes)
4. Hit run?

Apologies for the mess. YMMV.


Netris Edits:

Overview:
	Killing a row now creates a fog cloud over the enemy's board.

Specifics:
	- Added a new type of Message to sync fog clouds. GMScript now contains SendFogMessage and ReceiveFogMessage. This message is sent/received every time a row is killed.
	- The message specifies the Vector3 position of the fog cloud, which the receiver uses to instantiate a fog cloud prefab, which hovers for 12 seconds.