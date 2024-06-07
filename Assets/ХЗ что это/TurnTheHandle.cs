using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTheHandle : MonoBehaviour
{
    [SerializeField] private Animator animator;


    public void Turn()
    {
        StartCoroutine(StartAnimation());
    }

    private IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(2);
        animator.SetInteger("TurnHandle", 1);
    }
}
