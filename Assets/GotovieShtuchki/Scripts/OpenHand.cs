using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHand : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void Open()
    {
        animator.SetBool("IsOpen", true);
    }
}
