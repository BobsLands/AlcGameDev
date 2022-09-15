using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloona : MonoBehaviour
{
    public int scoreToGive = 100;

    public ScoreManager scoreManager;

    public int clickToPop = 3;

    public float scaleToIncrease = 0.10f;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        clickToPop -= 1;
        //clickToPop = clickToPop -1
         transform.localScale += Vector3.one * scaleToIncrease;
         if(clickToPop == 0)
         {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
 
         }
         


    }
}
