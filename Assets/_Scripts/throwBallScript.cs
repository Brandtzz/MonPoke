using UnityEngine;
using System.Collections;

public class throwBallScript : MonoBehaviour 
{

    static public throwBallScript BallScript; 
    private Vector3 CameraPosition; 
    public GameObject launchPoint; 

    public GameObject monPokeCatcher;
	Transform prefabMonPokeCatcher;

    public bool aimingMode; 

    public float Velocity = 1000;
	private float BallTimer = 0;
	private float timeToDestroy = 0;

    void Awake()
    {
        BallScript = this;
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject; 
        launchPoint.SetActive(true);
        CameraPosition = launchPointTrans.position; 
    }

    void ShootBall()
    {
		aimingMode = true;
        monPokeCatcher = Instantiate(monPokeCatcher) as GameObject;
        monPokeCatcher.transform.position = launchPoint.transform.position;
        monPokeCatcher.GetComponent<Rigidbody>().isKinematic = false;
		monPokeCatcher.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * Velocity);

    }

    void Update()
    {
		BallTimer += Time.deltaTime;
		timeToDestroy += Time.deltaTime;

		if (Input.GetMouseButtonDown (0) && BallTimer >= 5) {
			ShootBall ();
			BallTimer = 0;
		}

		DestroyBall ();
    }

	void DestroyBall() {
		
		if (timeToDestroy >= 3) {
			Destroy (monPokeCatcher, timeToDestroy);
			timeToDestroy = 0;
		}

		if (gameObject == null) {
			//GameObject.Instantiate (monPokeCatcher);
//			GameObject = Instantiate (prefabMonPokeCatcher);
		}
	}

}
