using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    [SerializeField]
    GameObject spawnPoint;
    [SerializeField]
    GameObject meteor;
    private Timer timer;
    private Timer period;
    private float timeSpawnMeteor = 0.2f;
    private float minX;
    private float maxX;
    // Start is called before the first frame update
    public void Spawn()
    {
        minX = spawnPoint.transform.position.x;
        maxX = spawnPoint.transform.position.x + 36f;
        Vector3 spawnPosition = spawnPoint.transform.position;
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), spawnPosition.y, spawnPosition.z);
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = timeSpawnMeteor;
        timer.run();
        period = gameObject.AddComponent<Timer>();
        period.Duration = 5;
        period.run();
        Instantiate(meteor, randomPosition, Quaternion.identity);
    }

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!period.Finished)
        {
            minX = spawnPoint.transform.position.x;
            maxX = spawnPoint.transform.position.x + 36f;
            Vector3 spawnPosition = spawnPoint.transform.position;
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), spawnPosition.y, spawnPosition.z);
            if (timer.Finished)
            {
                Instantiate(meteor, randomPosition, Quaternion.identity);
                timer.Duration = timeSpawnMeteor;
                timer.run();
            }
        }
    }
}
