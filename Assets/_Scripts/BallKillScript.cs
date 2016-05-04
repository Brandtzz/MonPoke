using UnityEngine;
using System.Collections;

public class BallKillScript : MonoBehaviour {

	public float Seconds = 5f;

	// Use this for initialization
	void Start () {
		StartCoroutine (KillAfter(Seconds));
	}

	public IEnumerator KillAfter(float seconds) {
		yield return new WaitForSeconds (seconds);
		Destroy (transform.gameObject);
	}
}
