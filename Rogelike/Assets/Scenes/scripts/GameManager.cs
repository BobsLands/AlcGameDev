using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;


    public void AddKey(int amount)
    {
        key += amount; // adds keys
        Debug.Log("Keys = "+ key); //shows how many keys in inventory
    }
}
