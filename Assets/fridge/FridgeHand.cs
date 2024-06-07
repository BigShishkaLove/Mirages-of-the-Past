using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FridgeHand : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;
    public GameObject FridgeDoor;
    private OpenFridgeDoor _moving;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
        _moving = FridgeDoor.GetComponent<OpenFridgeDoor>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FridgeHand")
        {
            Destroy(other.gameObject);
            rend.sharedMaterial = materials[1];
            _moving.MoveDoor();
        }
    }
}
