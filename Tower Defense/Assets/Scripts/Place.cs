using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private SpriteRenderer SpriteRenderer;
    private GameObject tower;

    public Texture2D hoverPlace;
    private Texture2D TurretPlace;

    private SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        TurretPlace = spriteRenderer.sprite.texture;
    }
    void OnMouseEnter(){
        if (hoverPlace != null){
            spriteRenderer.sprite = Sprite.Create(hoverPlace, spriteRenderer.sprite.rect, new Vector2(0.5f, 0.5f));
        }
    }
    void OnMouseExit(){
        spriteRenderer.sprite = Sprite.Create(TurretPlace, spriteRenderer.sprite.rect, new Vector2(0.5f, 0.5f));
    }
    private void OnMouseDown(){
        if(tower != null) return;
        Tower towerToBuild = Bulding.main.GetSelectedTower();
        if(towerToBuild.cost> GameManager.main.currency){
            Debug.Log("Nemůžeš si to dovolit");
            return;
        }

        GameManager.main.SpendCurrency(towerToBuild.cost);
        tower=Instantiate(towerToBuild.prefab,transform.position, Quaternion.identity);
    }
}
