using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void MoveShelf()
    {
        animator.SetBool("Moving", true);
    }
}
