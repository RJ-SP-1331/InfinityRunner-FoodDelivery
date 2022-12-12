using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 gravity;
    public Vector3 jumpspeed;
    

    bool isGrounded = false;
    Rigidbody rb;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && isGrounded)
        {
            
            rb.velocity = jumpspeed;
            isGrounded = false;
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
   
}
