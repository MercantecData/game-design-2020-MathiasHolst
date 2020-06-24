using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour
{

public GameObject spiller;
public Text ui_text;
public GameObject restartButton;
public GameObject menuButton;
float currentTime;
public float startingTime = 60;


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
    currentTime -= 1 * Time.deltaTime;
    ui_text.text = currentTime.ToString("0");

    if (currentTime <= 0)
    {
        currentTime = 0;
        ui_text.color = Color.red;
        if(spiller.active){
            ui_text.transform.position = new Vector2(500, 200);
            ui_text.color = Color.green;
            ui_text.text = "42";
            Time.timeScale = 0;
        } else {
            ui_text.transform.position = new Vector2(500, 200);
            ui_text.text = "You Lose";
            restartButton.SetActive(true);
            menuButton.SetActive(true);
        }
    }
    if (spiller == null){
        ui_text.transform.position = new Vector2(500, 200);
        ui_text.color = Color.red;
        ui_text.text = "You Lose";
        restartButton.SetActive(true);
        menuButton.SetActive(true);
        
    }
}
}
