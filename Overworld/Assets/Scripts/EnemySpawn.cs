using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
	public GameObject enemy;                // The enemy prefab to be spawned.
	public GameObject WorldBounds;			// The object used to represent the bounds of the world
	public Transform Player;
	public int EnemiesToSpawn = 5;			// Determines how many enemies you want to spawn

	// Use this for initialization
	void Start () {
		Vector3 WorldSize = WorldBounds.transform.lossyScale;
		int ShouldSpawn = 0;
		Vector3[] PossibleLocations = new Vector3[(int)(WorldSize.x*WorldSize.y)];
		Vector3 Temp = new Vector3(0,0,0);
		int ArrayIndex = 0;

		for (int i = 0; i<WorldSize.x; i++) 
		{
			for (int j = 0; j<WorldSize.y; j++)
			{
				//print (j);
				Temp.x = (float)i;
				Temp.y = (float)j;
				Temp.z = (float)-5;
				if(Temp != Player.position)
				{
					PossibleLocations[ArrayIndex] = Temp;
				}

				ArrayIndex++;
			}
		}
		int SpawnLength = ArrayIndex;

		for (int i = 0; i<EnemiesToSpawn; i++) {
			ArrayIndex = Random.Range (0, SpawnLength);
			print (PossibleLocations[ArrayIndex]);
			Instantiate (enemy, PossibleLocations[ArrayIndex], Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {
		

	}
}
