using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xValue = 0;
    [SerializeField] private float yValue = 0.5f;
    [SerializeField] private float zValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
