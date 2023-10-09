using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private int HP = 3;
    [SerializeField] private GameObject canvasHP;
    private void Awake()
    {
        canvasHP = GameObject.Find("HP");
        textMeshProUGUI = canvasHP.GetComponent<TextMeshProUGUI>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Untagged")
        {
            
            HP--;
        }
    }
    private void Update()
    {
        textMeshProUGUI.text = "HP: " + HP;
        if (HP == 0) SceneLoader.LoadCurrentScene();
            
    }

 
}
