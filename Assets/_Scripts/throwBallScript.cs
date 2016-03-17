using UnityEngine;
using System.Collections;

public class throwBallScript : MonoBehaviour 
{

    static public throwBallScript BallScript; 
    private Vector3 CameraPosition; 
    private Vector3 ThrowScale; 
    public GameObject launchPoint; 


    public GameObject monPokeCatcher;
    public GameObject prefabMonPokeCatcher;

    public bool aimingMode; 

    [Range (0f, 10000f)]
    public float Velocity = 1000;


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
        monPokeCatcher.GetComponent<Rigidbody>().useGravity = true; 
        monPokeCatcher.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * Velocity);

    }

   /* void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            monPokeCatcher.GetComponent<Rigidbody>().isKinematic = false; 
            monPokeCatcher.GetComponent<Rigidbody>().AddForce(transform.forward * Velocity);

        }
    }*/

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBall(); 
        }
    }






}
