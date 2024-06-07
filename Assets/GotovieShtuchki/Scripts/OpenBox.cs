using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour
{
    public GameObject ring1;
    public GameObject ring2;
    public GameObject ring3;
    private float delta = 30;

    public bool Check()
    {
        float ring1_angle = ring1.transform.rotation.eulerAngles.z;
        float ring2_angle = ring2.transform.rotation.eulerAngles.z;
        float ring3_angle = ring3.transform.rotation.eulerAngles.z;
        if ((ring1_angle >= 288 - delta && ring1_angle <= 288 + delta) && (ring2_angle >= 288 - delta && ring2_angle <= 288 + delta) && (ring3_angle >= 72 - delta && ring3_angle <= 72 + delta))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
