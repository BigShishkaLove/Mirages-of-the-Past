using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vinylScript : MonoBehaviour
{

    public Material[] materials;
    Renderer rend;
    public GameObject handle;
    public GameObject spine;
    private TurnTheSpine _turningSpine;
    private TurnTheHandle _turningHandle;
    public GameObject barrel;
    [SerializeField] private Animator animator;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];
        _turningSpine = spine.GetComponent<TurnTheSpine>();
        _turningHandle = handle.GetComponent<TurnTheHandle>();
        barrel.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "vinyl")
        {
            Destroy(other.gameObject);
            rend.sharedMaterial = materials[1];
            gameObject.GetComponent<SphereCollider>().enabled = false;
            gameObject.GetComponent<MeshCollider>().enabled = true;
            _turningSpine.Turn();
            _turningHandle.Turn();
            StartCoroutine(StartAnimation());
        }
    }

    private IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(5);
        animator.SetInteger("TurnDisk", 1);
        barrel.GetComponent<Rigidbody>().isKinematic = false;
    }
}
