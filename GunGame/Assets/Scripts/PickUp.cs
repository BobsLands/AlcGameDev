using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickUpType
    {
        Health,
        Ammo
    }

public class PickUp : MonoBehaviour
{
    [Header("Pickup Stats")]
    public PickUpType type;
    public int HealthAmount;
    public int AmmoAmount;


    [Header("Bobbing Anim")]
    public float rotationSpeed;
    public float bobSpeed;
    public float bobHight;

    private Vector3 startPos;
    private bool bobbingUp;
    public AudioClip pickupstx;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerControler player = other.GetComponent<PlayerControler>();
            switch(type)
            {
                case PickUpType.Health:
                player.GiveHealth(AmmoAmount);
                break;

                case PickUpType.Ammo:
                player.giveAmmo(HealthAmount);
                break;
            } 

            Destroy(gameObject);



        }
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
       Vector3 offset = (bobbingUp == true ? new Vector3(0,bobHight / 2,0) : new Vector3(0,bobHight / 2,0));
       transform.position = Vector3.MoveTowards(transform.position, startPos + offset, bobSpeed * Time.deltaTime);

       if(transform.position == startPos + offset)
       {

       }
    }   
   

}
