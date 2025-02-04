using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuckooClock : MonoBehaviour
{
    public float speed = 5;

    public AudioSource cuckoo;
    public AudioClip clock;

    int hour = 30;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (hour > 360)
        {
            hour = 30;
        }

        transform.Rotate(0, 0, -speed * Time.deltaTime);

        if (transform.rotation.z / -hour == 1)
        {
            for (int i = 0; i <= (hour / 30); i++)
            {
                cuckoo.PlayOneShot(clock);
            }

            hour += 30;
        }
    }
}
