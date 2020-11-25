using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionWithTunnel : MonoBehaviour { 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        //Si l'avion percute un mur.
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }


    }
}
