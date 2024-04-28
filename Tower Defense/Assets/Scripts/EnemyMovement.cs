using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Rigidbody2D Rigidbody2D;

    [Header("Atributy")]
    [SerializeField] private float moveSpeed = 2f;

    private float normalSpeed;

    private Transform target;
    private int pathIndex = 0;

    private void Start(){
        normalSpeed = moveSpeed;
        target = GameManager.main.path[pathIndex];
    }
    private void Update(){
        if (Vector2.Distance(target.position, transform.position) <= 0.1f){
            pathIndex++;
            if(pathIndex >= GameManager.main.path.Length){
                EnemySpawner.onEnemyDestroy.Invoke();
                Destroy(gameObject);
                GameManager.main.healths -= health.main.hp;
                return;
            }else{
                target = GameManager.main.path[pathIndex];
            }
        }
    }
    private void FixedUpdate(){
        Vector2 direction = (target.position - transform.position).normalized;

        Rigidbody2D.velocity=direction * moveSpeed;
    }
    public void UpdateSpeed (float newSpeed){
        moveSpeed = newSpeed;
    }
    public void ResetSpeed(){
        moveSpeed = normalSpeed;
    }
}
