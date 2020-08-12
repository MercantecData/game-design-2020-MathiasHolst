using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Game2Controller : MonoBehaviour
{
public GameObject spiller;
public Text ui_text;
public GameObject restartButton;
public GameObject menuButton;
float currentTime;
public float startingTime = 0;

public void Awake(){
    currentTime = startingTime;
    restartButton.SetActive(false);
    menuButton.SetActive(false);
}

public GameObject dontDestroy;

public void Start(){
    DontDestroyOnLoad(this.gameObject);
}

public void FixedUpdate()
{
    currentTime += 1 * Time.deltaTime;
    ui_text.text = currentTime.ToString("0");

    if (spiller == null){
        ui_text.transform.position = new Vector2(Screen.width/2, Screen.height/2);
        ui_text.color = Color.red;
        ui_text.text = "You Survived " + currentTime.ToString("0") + " seconds";
        Time.timeScale = 0;
        restartButton.SetActive(true);
        menuButton.SetActive(true);
        
    }
}

}
