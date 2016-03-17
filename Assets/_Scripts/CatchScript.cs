using UnityEngine;
using System.Collections;

public class CatchScript : MonoBehaviour {

   

   void OnCollisionEnter(Collision collision)
    {       
        if (collision.gameObject.CompareTag("Catch"))
        {
            Destroy(collision.gameObject, 0.1F);
            ScoreScript.S.MonsterCounter(); 

        }

        /*ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;*/
       
    }


   
}
