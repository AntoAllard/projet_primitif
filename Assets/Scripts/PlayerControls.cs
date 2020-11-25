using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
public float speed;

void Start()
{
}

void FixedUpdate()
{
    float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
    float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Translate(x, 0, z);
}
}