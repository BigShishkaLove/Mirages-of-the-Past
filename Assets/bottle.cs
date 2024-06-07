using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class bottle : MonoBehaviour
{

    int CountOfTheRightBottles;
    public GameObject shelf;
    private move _moving;

    private void Start()
    {
        CountOfTheRightBottles = 0;
        _moving = shelf.GetComponent<move>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bottle")
        {
            other.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            other.gameObject.GetComponent<MeshCollider>().enabled = false;
            other.gameObject.GetComponent<XRGrabInteractable>().enabled = false;
            CountOfTheRightBottles++;
            if (CountOfTheRightBottles == 9)
            {
                _moving.MoveShelf();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        CountOfTheRightBottles--;
    }
}
