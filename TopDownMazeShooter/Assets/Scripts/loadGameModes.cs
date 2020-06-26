using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGameModes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadSurvival(){
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void loadEndurance(){
        SceneManager.LoadScene("Game2");
        Time.timeScale = 1;
    }
}
