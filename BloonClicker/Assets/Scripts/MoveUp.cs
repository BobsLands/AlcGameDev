using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 25.0f;
    private Bloona bloona;
    public scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        bloona = GetComponent<Bloona>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(bloona.scoreToGive); //subtractscore to give from toltal
            Destroy(gameObject);
        }
    }
}
