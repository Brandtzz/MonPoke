using UnityEngine;
using System.Collections;

public class CreatureCatchScript : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {       
        if (collision.gameObject.CompareTag("Catch"))
        {
            Destroy(collision.gameObject, 0.1F);
            ScoreScript.S.MonsterCounter(); 

        }
    }

   
}
