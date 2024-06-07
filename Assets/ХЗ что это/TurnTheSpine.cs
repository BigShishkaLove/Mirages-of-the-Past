using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTheSpine : MonoBehaviour
{
    [SerializeField] private Animator animator;


    public void Turn()
    {
        animator.SetInteger("TurnSpine", 1);
    }
}
