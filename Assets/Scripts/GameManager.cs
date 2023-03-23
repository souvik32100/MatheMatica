using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Level"+1);
    }
    public void Home()
    {
        SceneManager.LoadScene("Level" + 0);
    }

    public void NextLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Level"+(scene.buildIndex+1));
    }
    public void RetryLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Level" + scene.buildIndex);
    }
}
