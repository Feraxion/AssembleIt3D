using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChange : MonoBehaviour
{

    public Material matObj;
    Renderer rend;
    public GameObject cpuObj;
    public GameObject batteryObj;
    public GameObject backObj;
    public GameObject particleVFX;




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
            foreach (Transform child in particleVFX.transform)
            {
                child.GetComponent<ParticleSystem>().Play();
            }
        }
        if (other.gameObject.tag == "CPU")
        {
            cpuObj.SetActive(true);
            Destroy(other.gameObject);
            foreach (Transform child in particleVFX.transform)
            {
                child.GetComponent<ParticleSystem>().Play();
            }
        }
        if (other.gameObject.tag == "Battery")
        {
            batteryObj.SetActive(true);
            Destroy(other.gameObject);
            foreach (Transform child in particleVFX.transform)
            {
                child.GetComponent<ParticleSystem>().Play();
            }
        }
        if (other.gameObject.tag == "Backside")
        {
            backObj.SetActive(true);
            Destroy(other.gameObject);
            foreach (Transform child in particleVFX.transform)
            {
                child.GetComponent<ParticleSystem>().Play();
            }
        }
    }
}
