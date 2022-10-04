using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddKey(int amount)
    {
        key += amount; // adds keys
        print("Keys = "+ key); //shows how many keys in invantory
    }
}
