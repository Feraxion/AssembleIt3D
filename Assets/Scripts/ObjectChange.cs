using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChange : MonoBehaviour
{

    public Material matObj;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ChangeBody")
        {
            rend.sharedMaterial = matObj;
            Destroy(other.gameObject);
        }
    }
}
