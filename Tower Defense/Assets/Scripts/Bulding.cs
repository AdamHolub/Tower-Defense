using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulding : MonoBehaviour
{
      public static Bulding main;

      [Header("Reference")]
      [SerializeField] private Tower[] towers;

      private int selectedTower = 0;

      private void Awake(){
          main=this;
      }
      public Tower GetSelectedTower(){
          return towers[selectedTower];
      }
      public void SetSelectedTower(int _seLectedTower){
          selectedTower= _seLectedTower;
      }
} 
