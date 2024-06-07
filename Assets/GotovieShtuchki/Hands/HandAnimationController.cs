using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class HandAnimationController : MonoBehaviour
{
    //public Animator leftHandAnimator;
    public Animator rightHandAnimator;
    public GameObject rightHandController;
    public InputActionProperty inputActionPropertyButton;
    private void FixedUpdate()
    {
        float pushValue = inputActionPropertyButton.action.ReadValue<float>();
        if (pushValue > 0)
        {
            rightHandAnimator.SetBool("isPointing", true);
            SphereCollider[] MyComponents = rightHandController.GetComponents<SphereCollider>();
            MyComponents[0].enabled = false;
            MyComponents[1].enabled = true;
            rightHandController.GetComponent<XRDirectInteractor>().enabled = false;

        }
        else
        {
            rightHandAnimator.SetBool("isPointing", false);
            SphereCollider[] MyComponents = rightHandController.GetComponents<SphereCollider>();
            MyComponents[0].enabled = true;
            MyComponents[1].enabled = false;
            rightHandController.GetComponent<XRDirectInteractor>().enabled = true;
        }
    }
}
