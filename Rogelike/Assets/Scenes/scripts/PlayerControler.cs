using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed; //how fast

    public float hInput; //horizontal input
    public float vInput; //vertical controler

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

//moves the charicter
        transform.Translate(Vector2.right * hInput * speed * Time.deltaTime);
        transform.Translate(Vector2.up * vInput * speed * Time.deltaTime);

    }
}
