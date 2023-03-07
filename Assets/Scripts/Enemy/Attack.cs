using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private Animator animator;
    private Timer timer;
    private GameObject tower;
    private DataEnemy dataEnemy;
    // Start is called before the first frame update
    void Start()
    {
        dataEnemy = gameObject.GetComponent<DataEnemy>();
        animator = GetComponent<Animator>();
        timer = gameObject.AddComponent<Timer>();
        tower = GameObject.FindGameObjectWithTag("Tower");
        timer.Duration = dataEnemy.timeAttack;
        timer.run();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(gameObject.transform.position, tower.transform.position));
        float distanceBetweenEnemyAndTower = Vector3.Distance(gameObject.transform.position, tower.transform.position);
        if (distanceBetweenEnemyAndTower < dataEnemy.distanceBetweenEnemyAndTower)
        {
            if (timer.Finished)
            {
                AttackTower();
            }
        }
    }

    public void AttackTower()
    {
        animator.SetBool("isAttack", true);
        timer.Duration = dataEnemy.timeAttack;
        timer.run();
        //TODO: Xử lí trừ máu trụ
    }
}
