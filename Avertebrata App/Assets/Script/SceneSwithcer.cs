﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwithcer : MonoBehaviour
{
    public void NextScene (){
        SceneManager.LoadScene("Menu_Hewan");
    }
}
