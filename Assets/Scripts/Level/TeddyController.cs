﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TeddyController : MonoBehaviour {

    private TeddyModell teddyModell;
    private TeddyView teddyView;


    private void Awake()
    {
        teddyView = GetComponent<TeddyView>();
        teddyModell = GetComponent<TeddyModell>();
    }


    private void Update()
    {
        if(CrossPlatformInputManager.GetButtonDown("Repel"))
        {
            teddyModell.ActivateLight();
        }
    }


    private void FixedUpdate()
    {
        // Read the inputs.
        bool crouch = Input.GetKey(KeyCode.LeftControl);
        float h = CrossPlatformInputManager.GetAxis("Horizontal");

        if (GameLogic.instance.gamePaused)
        {
            crouch = false;
            h = 0;
        }

        // Pass all parameters to the character control script.
        teddyView.input.x = h;
        teddyModell.Move(h);
    }
}

