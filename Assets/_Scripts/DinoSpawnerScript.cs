using UnityEngine;
using System.Collections;

public class DinoSpawnerScript : MonoBehaviour {

    public GameObject[] allosarus_Red; 
    public GameObject[] allosarus_Grey;
    public GameObject[] allosarus_Green; 

    public int amount_RedDino;
    public int amount_GreyDino;
    public int amount_GreenDino;

    private Vector3 spawnPoint; 

	void Update () 
    {
        allosarus_Red = GameObject.FindGameObjectsWithTag ("CatchRedDino");
        amount_RedDino = allosarus_Red.Length;

		allosarus_Grey = GameObject.FindGameObjectsWithTag ("CatchGreyDino");
		amount_GreyDino = allosarus_Grey.Length;

		allosarus_Green = GameObject.FindGameObjectsWithTag ("CatchGreenDino");
		amount_GreenDino = allosarus_Green.Length;

        if (amount_RedDino <= 5 )
            InvokeRepeating ("RedSpawn", 1, 5f);
		
		if (amount_GreyDino <= 5)
			InvokeRepeating ("GreySpawn", 1, 5f);

		if (amount_GreenDino <= 5)
			InvokeRepeating ("GreenSpawn", 1, 5f);
	}

    void RedSpawn()
    {
        spawnPoint.x = Random.Range (277, 215 );
        spawnPoint.y = 52f;
        spawnPoint.z = Random.Range (879, 927 );

        Instantiate (allosarus_Red [UnityEngine.Random.Range (0, allosarus_Red.Length - 1)], spawnPoint, Quaternion.identity);
        CancelInvoke ();
    }

	void GreySpawn() {
		spawnPoint.x = Random.Range (835, 960);
		spawnPoint.y = 55f;
		spawnPoint.z = Random.Range (910, 935);

		Instantiate (allosarus_Grey [UnityEngine.Random.Range (0, allosarus_Grey.Length - 1)], spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}

	void GreenSpawn() {
		spawnPoint.x = Random.Range (48, 68);
		spawnPoint.y = 51f;
		spawnPoint.z = Random.Range (390, 465);

		Instantiate (allosarus_Green [UnityEngine.Random.Range (0, allosarus_Green.Length - 1)], spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}
}
