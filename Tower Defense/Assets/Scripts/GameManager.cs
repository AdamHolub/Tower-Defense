using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager main;
    public Transform startPoint;
    public Transform[] path;
    public Transform endPoint;

    public int currency;
    public int healths;

    private void Awake(){
        main=this;
    }
    private void Start(){
        currency = 100;
        healths = 100;
    }
    public void IncreaseCurrency(int amount){
        currency+=amount;
    }
    public bool SpendCurrency(int amount){
        if (amount<=currency){
            currency-=amount;
            return true;
        }else{
            Debug.Log("Nemáš dostatek peněz");
            return false;
        }
    }
}
