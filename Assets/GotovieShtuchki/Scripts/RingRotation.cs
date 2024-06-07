using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RingRotation : MonoBehaviour
{
    public GameObject top;
    private OpenBox _openBox;
    private OpenTop _openTop;
    public InputActionProperty inputActionPropertyButton;
    public InputActionProperty inputActionPropertyLeftStick;

    private void Start()
    {
        _openBox = top.GetComponent<OpenBox>();
        _openTop = top.GetComponent<OpenTop>();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "hand")
        {
            float pushValue = inputActionPropertyButton.action.ReadValue<float>();
            Vector2 rotateValue = inputActionPropertyLeftStick.action.ReadValue<Vector2>();
            rotateValue.Inverse();
            if(pushValue > 0)
            {
                if(rotateValue.y != 0)
                {
                    var angles = transform.rotation.eulerAngles;
                    angles.z -= rotateValue.y*3;
                    transform.rotation = Quaternion.Euler(angles);
                    if (_openBox.Check())
                    {
                        _openTop.Open();
                    }
                }
            }
        }
    }
}
