using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestForce : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -0.25f), ForceMode.Impulse);
        }
    }
}
