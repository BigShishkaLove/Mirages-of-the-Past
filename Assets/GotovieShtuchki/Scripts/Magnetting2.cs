using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetting2 : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;
    public bool OnPlace;
    public GameObject other_tripod;
    public Light lantern;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
        OnPlace = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "detail2")
        {
            Destroy(other.gameObject);
            rend.sharedMaterial = materials[1];
            OnPlace = true;
            if (other_tripod.GetComponent<Magnetting>().OnPlace)
            {
                lantern.GetComponent<Light>().enabled = true;
            }
            gameObject.GetComponent<SphereCollider>().enabled = false;
            gameObject.GetComponent<MeshCollider>().enabled = true;
        }
    }
}
