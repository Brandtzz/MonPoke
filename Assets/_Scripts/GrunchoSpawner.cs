using UnityEngine;
using System.Collections;

public class GrunchoSpawner : MonoBehaviour {

	public GameObject[] gruncho;

	public int amount;

	private Vector3 spawnPoint;

	// Update is called once per frame
	void Update () {
		gruncho = GameObject.FindGameObjectsWithTag ("Catch");
		amount = gruncho.Length;

		if (amount <= 10) {
			InvokeRepeating ("spawnGrunchoCampsite", 1, 5f);
		} 
		else if (amount <= 20) {
			InvokeRepeating ("spawnGrunchoCampsite2", 1, 5f);
		}
	}

	void spawnGrunchoCampsite() {
		spawnPoint.x = Random.Range (319, 513);
		spawnPoint.y = 55f;
		spawnPoint.z = Random.Range (70, 347);

		Instantiate (gruncho [UnityEngine.Random.Range (0, gruncho.Length - 1)], spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}

	void spawnGrunchoCampsite2() {
		spawnPoint.x = Random.Range (513, 870);
		spawnPoint.y = 55f;
		spawnPoint.z = Random.Range (100, 250);
			
		Instantiate (gruncho [UnityEngine.Random.Range (0, gruncho.Length - 1)], spawnPoint, Quaternion.identity);
		CancelInvoke ();
	}
}

