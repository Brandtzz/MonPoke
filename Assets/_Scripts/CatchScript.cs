using UnityEngine;
using System.Collections;

public class CatchScript : MonoBehaviour {

   

   void OnCollisionEnter(Collision collision)
    {       
        if (collision.gameObject.CompareTag("Catch"))
        {
            Destroy(collision.gameObject, 0.1F);
            ScoreScript.S.GrouchoCounter(); 

        }
        else if (collision.gameObject.CompareTag("CatchRedDino"))
        {
            Destroy(collision.gameObject, 0.1F);
            ScoreScript.S.RedDinoCounter(); 
        }

        else if (collision.gameObject.CompareTag("CatchGreyDino"))
        {
            Destroy(collision.gameObject, 0.1F);
            ScoreScript.S.GreyDinoCounter(); 
        }
        else if(collision.gameObject.CompareTag("CatchGreenDino"))
        {
            Destroy(collision.gameObject, 0.1F);
            ScoreScript.S.GreenDinoCounter(); 
        } 

        /*ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;*/
       
    }


   
}
