using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visual : MonoBehaviour
{
    public GameObject Object;
    void Start()
    {
        if (Object.tag == "Old time")
        {
            Object.SetActive(false);
        }
    }
}
