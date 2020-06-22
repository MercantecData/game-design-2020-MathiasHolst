using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

public GameObject spiller;
public Text ui_text;

    float currentTime;
public float startingTime = 60;


public void Awake(){
    currentTime = startingTime;
}

public void Update()
{
    currentTime -= 1 * Time.deltaTime;
    ui_text.text = currentTime.ToString("0");

    if (currentTime <= 0)
    {
        currentTime = 0;
        ui_text.color = Color.red;
        if(spiller.active){
            ui_text.color = Color.green;
            ui_text.text = "You Win";
            Time.timeScale = 0;
        } else {
            ui_text.text = "You Lose";

        }
    }
    if (spiller == null){
        ui_text.color = Color.red;
        ui_text.text = "You Lose";
    }
}
}
