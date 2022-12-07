using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    
    [Header("Player Stats")]
    public float MoveSpeed;
    public float JumpForce;
    [Header("Camera stats")]

    public float lookSensitivity;
    public float maxLookx;
    public float minLookx;
    private float rotx;
    private Camera camera;
    private Rigidbody rb;

    void Awake()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraLook();
        if(Input.GetButtonDown("Jump"))
           PlayerJump();
    }
    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal") * MoveSpeed;
        float z = Input.GetAxis("Vertical") * MoveSpeed;
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;




        rb.velocity = dir; //drivesmovement
    }
    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotx += Input.GetAxis("Mouse Y") * lookSensitivity;
        rotx = Mathf.Clamp(rotx, minLookx, maxLookx);
        camera.transform.localRotation = Quaternion.Euler(-rotx, 0, 0);
        transform.eulerAngles += Vector3.up * y;


    }
    void PlayerJump()
    {
        //Ground cheek
        Ray ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray, 1.1f))
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
    }
    public void GiveHealth(int amount)
    {
        Debug.Log("player picked up health");
    }
    public void giveAmmo(int amount)
    {
        Debug.Log("player picked up health");
    }

}
