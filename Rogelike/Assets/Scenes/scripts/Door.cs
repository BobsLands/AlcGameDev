using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm;
    public float doorDelay;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
   
        if(other.gameObject.CompareTag("Player") && gm.key >= 1)
        {
            Destroy(gameObject,doorDelay);
            Debug.Log("Door is unlocked");
            Debug.Log("Keys ="+ gm.key);
        }
        else
        {
            Debug.Log("Door is Locked. You need a key");
        }

    }

    
    
}
