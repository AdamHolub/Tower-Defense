using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public static health main;
    [Header("Atributy")]
    [SerializeField] private int hitPoints = 2;
    [SerializeField] private int currencyWorth = 20;
    [SerializeField] public int hp = 5;

    private bool isDestroyed = false;

    private void Awake(){
        main=this;
    }
    public void TakeDamage(int dmg){
        hitPoints -= dmg;

        if(hitPoints<=0 && !isDestroyed){
            EnemySpawner.onEnemyDestroy.Invoke();
            GameManager.main.IncreaseCurrency(currencyWorth);
            isDestroyed=true;
            Destroy(gameObject);
        }
    }
}
