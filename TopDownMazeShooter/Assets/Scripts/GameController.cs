using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
public static GameController instance;

public Text ui_text;

public void Awake(){
    instance = this;
}

    public int time = 60;

    public void SetTime(int time) {
        this.time = time;
        ui_text.Text = "Time left: " + time;
    }
}
