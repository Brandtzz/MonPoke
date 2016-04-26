using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    private int count;
    private int grouchoCount; 
    private int redDinoCount;
    private int greyDinoCount;
    private int greenDinoCount; 
    public Text countText;
    public Text winText; 

    private CatchScript catchScript;

    public static ScoreScript S;

    void Start()
    {
        S = this;
        catchScript = new CatchScript();
        count = 0;
        grouchoCount = 0;
        redDinoCount = 0;
        greyDinoCount = 0; 
        greenDinoCount = 0;
        setCountText();
        winText.text = "";
    }

   /* public void MonsterCounter()
    {
        
            count++;
            setCountText();

    }*/

    public void GrouchoCounter()
    {
        grouchoCount++;
        setCountText();
    }

    public void RedDinoCounter()
    {
        redDinoCount++;
        setCountText();
    }

    public void GreyDinoCounter()
    {
        greyDinoCount++;
        setCountText();
    }

    public void GreenDinoCounter()
    {
        greenDinoCount++;
        setCountText();
    }




    void setCountText()
    {
        countText.text = " Grouchos Caught " + grouchoCount.ToString () + "\n Red Dino Caught " + redDinoCount.ToString() + "\n Grey Dino Caught " + greyDinoCount.ToString() + "\n Green Dino Caught " + greenDinoCount.ToString();
        if (grouchoCount >= 1 && redDinoCount >= 1 && greyDinoCount >= 1 && greenDinoCount >= 1) 
        {
            winText.text = "Victory"; 
        }
    }
}
