using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    void movement()
    {
        Animator animatons = GetComponent<Animator>();
        animatons.Play("coinAnim");
    }
}
