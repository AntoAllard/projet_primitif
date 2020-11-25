using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionWithGold : MonoBehaviour
{

    public GameObject Tunnel;
    public GameObject[] spawnLocations;
   



    // Start is called before the first frame update
    void Start()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("SpawnPointTunnel");
    }


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            int spawn = Random.Range(0, spawnLocations.Length);
            GameObject.Instantiate(Tunnel, spawnLocations[spawn].transform.position, Quaternion.identity);
            Destroy(gameObject);
        }


    }
}
