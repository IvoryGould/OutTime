﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour
{
    private CursorLockMode lockMode;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider trigger)
    {
        SceneManager.LoadScene(0);
        lockMode = CursorLockMode.None;
        Cursor.lockState = lockMode;
    }
}
