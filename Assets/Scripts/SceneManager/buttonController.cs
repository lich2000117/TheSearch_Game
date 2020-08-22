﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void replay() {
		SceneManager.LoadScene("MainMaze");
	}
    public void play() {
        SceneManager.LoadScene("MainMaze");
    }
    public void achievements()
    {
        SceneManager.LoadScene("Achievements");
    }
    public void homePage()
    {
        SceneManager.LoadScene("HomePage");
    }
}
