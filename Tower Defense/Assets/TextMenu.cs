using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextMenu : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] TextMeshProUGUI currencyUI;
    [SerializeField] TextMeshProUGUI WaveBarUI;
    [SerializeField] TextMeshProUGUI HpBarUI;
    private void OnGUI(){
        currencyUI.text = GameManager.main.currency.ToString();
        WaveBarUI.text = EnemySpawner.main.currentWave.ToString();
        HpBarUI.text = GameManager.main.healths.ToString();
    }
}
