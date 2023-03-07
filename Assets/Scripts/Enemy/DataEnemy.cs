using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataEnemy : MonoBehaviour
{
    [SerializeField]
    public int damage;
    [SerializeField]
    public int health;
    [SerializeField]
    public float speed;
    [SerializeField]
    public float goldGiven;
    [SerializeField]
    public float timeAttack;
    [SerializeField]
    public float distanceBetweenEnemyAndTower;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Meteor")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
