using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boite : MonoBehaviour
{
    public ColorSwitch colorSwitch;
    public Rigidbody rb;
    public bool verifier;
    public bool checkCouleur;
    public Material Material1;
    public Material Material2;
    public GameObject Object;
    public float random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(0f, 1f);

        if (random < 0.5f)
        {
            Object.GetComponent<MeshRenderer>().material = Material1;
            checkCouleur = true;
        }
        if (random > 0.5f)
        {
            Object.GetComponent<MeshRenderer>().material = Material2;
            checkCouleur = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized;
        transform.position += transform.right * 0.01f;
    }
    public void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Machine" && Input.GetKeyDown(KeyCode.Space) && checkCouleur == colorSwitch.checkCouleur2)
        {
            verifier = true;
            Debug.Log(verifier);
        }
        
    }

}
