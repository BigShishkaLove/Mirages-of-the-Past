using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisionmod : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cube")
        {
            Console.WriteLine("1 ");
        }
    }
}
