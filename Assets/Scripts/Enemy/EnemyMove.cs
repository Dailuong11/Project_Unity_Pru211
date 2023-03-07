using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private bool isMoving;
    private GameObject tower;
    private DataEnemy dataEnemy;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = true;
        tower = GameObject.FindGameObjectWithTag("Tower");
        dataEnemy = gameObject.GetComponent<DataEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        float distanceBetweenEnemyAndTower = Vector3.Distance(gameObject.transform.position, tower.transform.position);

        if(distanceBetweenEnemyAndTower < dataEnemy.distanceBetweenEnemyAndTower)
        {
            isMoving = false;
        } else
        {
            isMoving = true;
        }
        if (isMoving)
        {
            float posX = transform.position.x - dataEnemy.speed * Time.deltaTime;
            transform.position = new Vector3(posX, transform.position.y, -Camera.main.transform.position.z);
        }
           
    }

}
