using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xValue = 0;
    [SerializeField] private float yValue = 5f;
    [SerializeField] private float zValue = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
