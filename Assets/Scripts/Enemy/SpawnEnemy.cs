using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnEnemy : MonoBehaviour
{

    [SerializeField]
    GameObject[] prefabsEnemy;

    [SerializeField]
    GameObject spawnPoint;

    private Timer timer;
    private int numberEnemySpawn = 1;
    private float enemySpawnRateIncrease = 1.1f;
    private float timeSpawnEnemy = 15;
    private int countTimeSpawn = 1;
    private int percentRandomBoss = 19;
    private float distanceBetweenObjects = 5;

    // Start is called before the first frame update
    void Start()
    {
        numberEnemySpawn = (int)Math.Ceiling(numberEnemySpawn * Mathf.Pow(enemySpawnRateIncrease, countTimeSpawn));
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = timeSpawnEnemy;
        timer.run();
        Instantiate(prefabsEnemy[0], spawnPoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Finished)
        {
            int percentRandomEnemy = (100 - percentRandomBoss) / 3;
            for (int i = 0; i < numberEnemySpawn; i++)
            {    
                int[] probabilities = new int[] { percentRandomEnemy, percentRandomEnemy, percentRandomEnemy, percentRandomBoss};
                GameObject prefabEnemyRandom = RandomWithProbability(prefabsEnemy, probabilities);
                Vector3 posSpawn = spawnPoint.transform.position + i * distanceBetweenObjects * transform.right;
                Instantiate(prefabEnemyRandom, posSpawn, Quaternion.identity);
            }
            if(percentRandomBoss < 99)
            {
                percentRandomBoss += 2;
            }
            countTimeSpawn++;
            numberEnemySpawn = (int)Math.Ceiling(numberEnemySpawn * Mathf.Pow(enemySpawnRateIncrease, countTimeSpawn));
            Debug.Log(numberEnemySpawn);
            timer.Duration = timeSpawnEnemy;
            timer.run();

        }
        
    }


    GameObject RandomWithProbability(GameObject[] values, int[] probabilities)
    {
        int sumOfProbabilities = 0;
        for (int i = 0; i < probabilities.Length; i++)
        {
            sumOfProbabilities += probabilities[i];
        }
        int randomValue = UnityEngine.Random.Range(1, sumOfProbabilities + 1);

        int currentProbability = 0;
        for (int i = 0; i < values.Length; i++)
        {
            currentProbability += probabilities[i];
            if (randomValue <= currentProbability)
            {
                return values[i];
            }
        }

        return values[values.Length - 1];
    }
}
