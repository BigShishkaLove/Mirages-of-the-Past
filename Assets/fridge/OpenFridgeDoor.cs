using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFridgeDoor : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void MoveDoor()
    {
        animator.SetBool("OpenFridge", true);
    }
}
