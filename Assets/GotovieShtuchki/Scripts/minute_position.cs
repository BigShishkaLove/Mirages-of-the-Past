using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minute_position : MonoBehaviour
{
    public GameObject door;
    public GameObject hour;
    public bool IsRight;
    private OpenDoor _open;

    private void Start()
    {
        IsRight = false;
        _open = door.GetComponent<OpenDoor>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "minute")
        {
            IsRight = true;
            hour_position _hour = hour.GetComponent<hour_position>();
            if (_hour.IsRight)
            {
                _open.Open();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        IsRight = false;
    }
}
