using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{

    [SerializeField] private int timeToWait = 10;
    new MeshRenderer renderer;
    new Rigidbody rigidbody;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
