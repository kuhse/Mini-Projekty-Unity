using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;
    void Start()
    {
            playerPosition = player.transform.position;
            

    }

    void Update()
    {
        MoveTowardsPlayer();
        DestroyWhenReached();

    }

    private void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, projectileSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        } 
        
    }
}
