using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync("MapSelector");
    }
    public void BackButton(){
        SceneManager.LoadSceneAsync("Main Menu");
    }
    public void FirstMapSelected(){
        SceneManager.LoadSceneAsync("GameMapOne");
    }
    public void SecondMapSelected(){
        SceneManager.LoadSceneAsync("GameMapTwo");
    }
    public void ThirdMapSelected(){
        SceneManager.LoadSceneAsync("GameMapThree");
    }
    public void Quit(){
        Application.Quit();
    }
}
