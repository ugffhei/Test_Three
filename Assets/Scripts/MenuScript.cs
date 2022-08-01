using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string nextLevelName;
    public AudioSource buttonSFX;
    
    public void GoToNextLevel()
    {
        buttonSFX.Play();
        SceneManager.LoadScene(nextLevelName);
    }

}
