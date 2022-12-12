using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScrollCoin : MonoBehaviour
{
    
    public float scrollfactor = -1;
    public Vector3 GameVelocity;
    Rigidbody rb;
    public GameObject Coin;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = GameVelocity * scrollfactor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        transform.position += Vector3.right * (other.bounds.size.x + GetComponent<BoxCollider>().size.x);
    }
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(Coin);
        GameManager.Actmonedas();

    }
    
}
