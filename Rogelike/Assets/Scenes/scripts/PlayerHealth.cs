using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Maxhealth = 3;
    public int Currenthealth;
    public float DeathDelay;
    

    // Start is called before the first frame update
    void Start()
    {
        Currenthealth = Maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int dmgAmount)
    {
        Currenthealth -= dmgAmount;

        if(Currenthealth <= 0)
        {
            Destroy(gameObject,DeathDelay);
        }
    }
        public void HealDamage(int healAmount)
    {
        Currenthealth += healAmount;

        if(Currenthealth >= Maxhealth)
        {
            Currenthealth = Maxhealth;
        }
    }
}

