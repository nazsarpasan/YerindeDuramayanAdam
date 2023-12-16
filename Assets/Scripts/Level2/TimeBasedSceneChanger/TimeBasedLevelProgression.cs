using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeBasedLevelProgression : MonoBehaviour
{
    public float _fadeinTime = 14.4f;
    public float unlockTime = 15f; // Time in seconds
    private float totalTime = 0f;
    public GameObject _fadeIn;

    void Update()
    {
        totalTime += Time.deltaTime;

        if (totalTime >= _fadeinTime)
        {
            _fadeIn.SetActive(true);
        }


        if (totalTime >= unlockTime)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            totalTime -= unlockTime;
        }
    }
}

