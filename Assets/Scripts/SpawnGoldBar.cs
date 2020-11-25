using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGoldBar : MonoBehaviour
{
    public GameObject goldBar;
    public GameObject[] spawnLocations;

    private bool hasSpawn = false;

    private float startDelay = 30f;
    private float goldTime;

    private int finalCount;

    void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    void Start()
    {
        goldTime = Time.time + startDelay;
    }

    void Update()
    {

        GameObject[] countGold;
        countGold = GameObject.FindGameObjectsWithTag("Lingot");
        finalCount = countGold.Length;

        if (Time.time > goldTime)
        {
            if (finalCount < 1 && hasSpawn == false)
            {
                int spawn = Random.Range(0, spawnLocations.Length);
                GameObject.Instantiate(goldBar, spawnLocations[spawn].transform.position, Quaternion.identity);
            }
            else
            {
                hasSpawn = true;
            }
        }
        
    }
}