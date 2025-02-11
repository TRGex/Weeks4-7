using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 burger;
    
    public float speed = 5;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);

        //if () 
        {

        }
    }
}
