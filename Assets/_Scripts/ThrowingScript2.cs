using UnityEngine;
using System.Collections; 

public class ThrowingScript2 : MonoBehaviour
{
    //
    public AudioClip throwSound;

    private RaycastHit hit;


    public GameObject launchPoint; 
    public GameObject monPokeCatcher;
    public GameObject prefabMonPokeCatcher;

    [Range (0f, 10000f)]
    public float Velocity = 1000;

    private float MaxRangeRayCast = 300f; 

    void Start()
    {
    }
        

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //AudioSource.PlayClipAtPoint(throwSound, transform.position);

            ShootBall();

            Debug.DrawRay(transform.position, transform.forward, Color.cyan, 5);
            Debug.Log("throw sound");

            if (Physics.Raycast(transform.TransformPoint(0, 0, 1), transform.forward, out hit,
                   MaxRangeRayCast))
            {
                Debug.Log("Ball hit " + hit.transform.name);
                if (hit.transform.tag == "Catch")
                {
                    hit.transform.GetComponent<CreatureCatchScript>();
                }
            }

        }
    }


    void ShootBall()
    {
        monPokeCatcher = Instantiate(monPokeCatcher) as GameObject;
        monPokeCatcher.transform.position = launchPoint.transform.position;
        monPokeCatcher.GetComponent<Rigidbody>().isKinematic = false; 
        monPokeCatcher.GetComponent<Rigidbody>().useGravity = true; 
        monPokeCatcher.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * Velocity);
    }
}