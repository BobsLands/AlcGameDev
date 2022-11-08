using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int eMaxhealth = 3;
    public int eCurrenthealth;
    public float eDeathDelay;
    

    // Start is called before the first frame update
    void Start()
    {
        eCurrenthealth = eMaxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int dmgAmount)
    {
        eCurrenthealth -= dmgAmount;

        if(eCurrenthealth <= 0)
        {
            Debug.Log("Enemy Died");
            Destroy(gameObject,eDeathDelay);
        }
    }
       
}
