using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name) {
        //Debug.Log ("New Level load: " + name);
        //	Application.LoadLevel (name);    -- This method was deprecated a long time ago
        SceneManager.LoadScene(name);
        Brick.breakableCount = 0;  }


    public void EndGame()  {
        //Debug.Log ("Quit requested");
        Application.Quit(); }


    //Added functions to the previous LevelManager script
    public void LoadNextLevel()   {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void BrickDestroyed() {
        if (Brick.breakableCount <= 0)   {
            LoadNextLevel(); }
    }

}