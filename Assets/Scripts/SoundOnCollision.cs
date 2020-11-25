using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnCollision : MonoBehaviour
{

    AudioSource cashRegister;
    public ParticleSystem cashParticles;
    public Text tunnel;

    // Start is called before the first frame update
    void Start()
    {
        cashRegister = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Lingot")
        {
            cashRegister.Play();
            Instantiate(cashParticles, transform.position, Quaternion.identity);
            tunnel.text = "Trouve le tunnel";
        }


    }
}
