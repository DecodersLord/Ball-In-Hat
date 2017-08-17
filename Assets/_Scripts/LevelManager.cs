using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    static int i = 0;
	public void LoadScene()
    {
        if(i == 3)
        {
            SceneManager.LoadScene("MainMenu");
        }else{
        
            i++;
            SceneManager.LoadScene("Level" + i);
        }
        
    }
    public void GameOver()
    {
        i = 0;
        SceneManager.LoadScene("GameOver");
    }
    public void Restart()
    {
        i = 0;
        SceneManager.LoadScene("MainMenu");
    }
}
