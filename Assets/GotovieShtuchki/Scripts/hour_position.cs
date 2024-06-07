using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hour_position : MonoBehaviour
{
    public GameObject door;
    public GameObject minute;
    public bool IsRight;
    private OpenDoor _open;

    private void Start()
    {
        IsRight = false;
        _open = door.GetComponent<OpenDoor>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hour")
        {
            IsRight = true;
            minute_position _minute = minute.GetComponent<minute_position>();
            if (_minute.IsRight)
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
