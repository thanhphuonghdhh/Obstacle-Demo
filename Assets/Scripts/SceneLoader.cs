using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] static int currentSceneIndex;
    public void Awake()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public static void LoadCurrentScene()
    {
        Debug.Log(currentSceneIndex);
        SceneManager.LoadScene(currentSceneIndex);
    }

    public static void LoadNextScene()
    {
        Debug.Log(currentSceneIndex);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
