using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public int health;
    public string name;
    public bool isFriendly;
    public float moveSpeed = 8f;

    private float tileScale = 0.25f;
    private float tileSize = 64;
    private bool isMoving = false;
    private Vector3 targetPosition;

    void Start()
    {
        tileSize *= transform.localScale.x * tileScale / 3;
    }

    public void Move(Vector2 direction)
    {
        if (!isMoving)
        {
            Vector3 movement = new Vector3(direction.x, direction.y, 0) * tileSize;
            targetPosition = new Vector3(
                transform.position.x + movement.x,
                transform.position.y + movement.y,
                transform.position.z
            );
            isMoving = true;
        }
    }


    public void Attack(Vector2 direction)
    {
        print($"attacked at: {direction}");
    }

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                isMoving = false;
            }
        }
    }
}
