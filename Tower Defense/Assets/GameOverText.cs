using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverText : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] TextMeshProUGUI WaveBarUI;

    private void OnGUI(){
        WaveBarUI.text = EnemySpawner.main.currentWave.ToString();
    }
    public void Backtomainmenu(){
        SceneManager.LoadScene("Main Menu");
    }
}
