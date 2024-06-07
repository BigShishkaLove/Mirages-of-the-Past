using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Rigidbody>().AddTorque(new Vector3(0, 30, 0), ForceMode.Impulse);
        }
    }
}
