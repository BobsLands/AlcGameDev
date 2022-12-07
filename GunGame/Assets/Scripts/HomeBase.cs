using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBase : MonoBehaviour
{
    private GameManager gm;
    private Renderer flagrend;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        flagrend = GameObject.Find("FlagHome").GetComponent<Renderer>();
        flagrend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gm.hasFlag)
        {
            Debug.Log("Player reached home");
            gm.PlaceFlag();

            flagrend.enabled = true;

        }
    }
}
