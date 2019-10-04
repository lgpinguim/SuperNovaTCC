using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour


{
    [Tooltip("InSeconds")]
    [SerializeField] float levelLoadDelay = 1f;

    [Tooltip("FX Prefab On Player")]
    [SerializeField] GameObject deathFX;

    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);

    }

    private void StartDeathSequence()
    {

        SendMessage("OnPlayerDeath");
    }

    private void ReloadScene() // string reference
    {
        SceneManager.LoadScene(1);
    }

}
