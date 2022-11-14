using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Ehealth;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void TakeDamage(int damage)
    {
        Ehealth -= damage;
        renderer.material.color = Color.red;
        
    }
}
