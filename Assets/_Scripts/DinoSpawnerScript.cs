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

        if (amount_RedDino <= 6 ) {
            InvokeRepeating ("AllosarusRedSpawn", 1, 5f);

        }
	}

    void AllosarusRedSpawn()
    {
        spawnPoint.x = Random.Range (277, 215 );
        spawnPoint.y = Random.Range (55f);
        spawnPoint.z = Random.Range (879, 927 );

        Instantiate (allosarus_Red [UnityEngine.Random.Range (0, allosarus_Red.Length - 1)], spawnPoint, Quaternion.identity);
        CancelInvoke ();

    }
}
