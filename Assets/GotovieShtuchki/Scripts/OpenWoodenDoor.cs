using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWoodenDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "key")
        {
            animator.SetBool("OpenWooden", true);
        }
    }
}
