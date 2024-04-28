using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Atributy")]
    [SerializeField] private float bulletSpeed = 5f;
    [SerializeField] private int bulletDamage = 1;

    public Transform target;
    public void SetTarget(Transform _target){
        target = _target;
    }
    private void FixedUpdate(){
        if(!target)return;
        Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * bulletSpeed;
    }
    private void OnCollisionEnter2D(Collision2D other){
        other.gameObject.GetComponent<health>().TakeDamage(bulletDamage);
        Destroy(gameObject);
    }
}
