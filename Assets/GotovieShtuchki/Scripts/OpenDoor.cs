using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    [SerializeField] private Animator animator;


    public void Open()
    {
        StartCoroutine(StartAnimation());
    }

    private IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(2);
        animator.SetInteger("OpenDoor", 1);
    }
    
}
