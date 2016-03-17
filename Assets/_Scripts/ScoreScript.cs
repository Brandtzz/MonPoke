using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    private int count;
    public Text countText;
    public Text winText; 

    private CatchScript catchScript;

    public static ScoreScript S;

    void Start()
    {
        S = this;
        catchScript = new CatchScript();
        count = 0;
        setCountText();
        winText.text = "";
    }

    public void MonsterCounter()
    {
        
            count++;
            setCountText();

    }


    void setCountText()
    {
        countText.text = "Monsters Caught " + count.ToString ();
        if (count >= 12) 
        {
            winText.text = "Victory"; 
        }
    }
}
