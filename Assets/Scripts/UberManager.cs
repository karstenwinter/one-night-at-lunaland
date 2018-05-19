﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UberManager : MonoBehaviour {

    public float hp = 0;
    public int matches = 1;
    public static UberManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
