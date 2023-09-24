using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            score++;
            Debug.Log("Time Bump: " + score);
        }
    }
}
