﻿//Author: Rok Kos <kosrok97@gmail.com>
//File: Turorial.cs
//File path: /D/Documents/Unity/GGJ2017/Turorial.cs
//Date: 23.01.2017
//Description: Checking triger in checpoints

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    private Tutorial tutorial;

    private void Start () {
        tutorial = (Tutorial)FindObjectOfType(typeof(Tutorial));
    }

    private void OnTriggerEnter2D (Collider2D other) {
        tutorial.checkpoints[tutorial.stageOfTutorial-1].SetActive(false);
        if (tutorial.stageOfTutorial < tutorial.checkpoints.Length) {
            tutorial.checkpoints[tutorial.stageOfTutorial].SetActive(true);
        }
        
        tutorial.stageOfTutorial++;
        tutorial.showInstrucitons();
    }


}
