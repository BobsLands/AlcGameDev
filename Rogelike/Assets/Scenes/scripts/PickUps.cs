using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour
{
    public string pickUpType;
    public int amount;
    public int value;
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponet<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider other)
    {
        //Pick up key
        if (other.gameObject.CompareTag("player"))
     {
        gm.AddKey(amount); // Add keys to inventory

        Destroy(gameObject);
     }
    }
}