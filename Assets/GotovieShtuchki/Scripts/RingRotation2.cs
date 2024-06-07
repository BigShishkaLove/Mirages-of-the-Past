using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;

public class RingRotation2 : MonoBehaviour
{
    public GameObject hand;
    public GameObject door;
    private OpenHand _openHand;
    private OpenClosedDoor _openDoor;
    public InputActionProperty inputActionPropertyButton;
    public InputActionProperty inputActionPropertyLeftStick;

    private void Start()
    {
        _openHand = hand.GetComponent<OpenHand>();
        _openDoor = hand.GetComponent<OpenClosedDoor>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            float pushValue = inputActionPropertyButton.action.ReadValue<float>();
            Vector2 rotateValue = inputActionPropertyLeftStick.action.ReadValue<Vector2>();
            rotateValue.Inverse();
            if (pushValue > 0)
            {
                if (rotateValue.y != 0)
                {
                    var angles = transform.rotation.eulerAngles;
                    angles.z -= rotateValue.y * 3;
                    transform.rotation = Quaternion.Euler(angles);
                    if (_openDoor.Check())
                    {
                        _openHand.Open();
                        door.GetComponent<Rigidbody>().isKinematic = false;
                    }
                }
            }
        }
    }
}
