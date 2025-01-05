using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Entity playerBody;
    void Start()
    {
        playerBody = transform.GetChild(0).GetComponent<Entity>();
    }
    public void Action(Vector2 direction, string type)
    {
        switch (type){
            case ("attack"):
                {
                    playerBody.Attack(direction);
                    break;
                }
            case ("move"):
                {
                    playerBody.Move(direction);
                    break;
                }
            default:
                {
                    print($"unknown action: {type}");
                    break;
                }
        }
    }
}
