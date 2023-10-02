using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] float timeRemaining = 120;
    TextMeshProUGUI m_TextMeshProUGUI;
    private float minutes;
    private float seconds;  
    private void Awake()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        } else SceneLoader.LoadCurrentScene();
        minutes = Mathf.FloorToInt(timeRemaining / 60);
        seconds = Mathf.FloorToInt(timeRemaining % 60);
        m_TextMeshProUGUI.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
