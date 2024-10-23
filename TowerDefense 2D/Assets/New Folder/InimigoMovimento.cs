using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMovimento : MonoBehaviour
{ 
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 2f;

    private Transform target;
    private int pathIndex = 0;
    private void Start()
    {
        target = LevelManager.main.path[pathIndex];

    }
    private void Update()
    {
        if (Vector2.Distance(target.position, transform.position)<=0.1f)
        {

            if (pathIndex==LevelManager.main.path.Length)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                pathIndex++;
                target = LevelManager.main.path[pathIndex];
            }
        }
    }
    private void FixedUpdate ()
    {
        Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
    }
}
