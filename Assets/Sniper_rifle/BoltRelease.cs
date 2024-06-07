using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltRelease : MonoBehaviour
{
    public float requiredRotation = 30f;
    public float requiredTranslation = -0.3f;

    private bool isRotated = false; 
    private float initialZ; 
    private float initialRotationX; 

    private Rigidbody rb; 
    private ConfigurableJoint joint;

    public Animator sniperAnimator;
    public Animator boltAnimator;

    public GameObject case1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        joint = GetComponent<ConfigurableJoint>();
        joint.linearLimit = new SoftJointLimit { limit = 0f };
        initialZ = rb.position.z;
        initialRotationX = rb.rotation.eulerAngles.x;
    }

    
    void Update()
    {
        if (!isRotated)
        {
            float currentRotationX = rb.rotation.eulerAngles.x;

            float deltaAngle = Mathf.Abs(currentRotationX - initialRotationX);

            if (!isRotated && deltaAngle >= requiredRotation)
            {
                isRotated = true;

                joint.linearLimit = new SoftJointLimit { limit = Mathf.Abs(requiredTranslation + 0.51f) };
            }
        }
        if (isRotated)
        {
            float currentTranslationZ = rb.position.z;
            float deltaTranslation = Mathf.Abs(currentTranslationZ - initialZ);

            if (-deltaTranslation <= requiredTranslation)
            {
                sniperAnimator.SetBool("Reload", true);
                isRotated = false;

                boltAnimator.SetBool("Returning", true);

                boltAnimator.enabled = true;

                case1.GetComponent<Rigidbody>().useGravity = true;
                case1.GetComponent<Rigidbody>().drag = 9;
            }
        }
    }
}
