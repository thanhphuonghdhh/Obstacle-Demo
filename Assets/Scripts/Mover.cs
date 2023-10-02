using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    
    [SerializeField] float moveSpeed = 4;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float z = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        transform.Translate(-x, 0, z);
    }
}
