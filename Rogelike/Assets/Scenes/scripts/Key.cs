using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : PickUps

   
{ 
    private GameManager gm;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame

     void OnTriggerEnter2D(Collider2D other)
    {
        //Pick up key
        if (other.gameObject.CompareTag("Player"))
     {
        gm.AddKey(amount); // Add keys to inventory

        Destroy(gameObject);
     }
    }
}
