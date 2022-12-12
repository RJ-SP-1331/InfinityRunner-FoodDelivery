using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    private IEnumerator SpawnObstacle()
    {
        while (true) 
        {
            int RandomIndex = Random.Range(0, obstacles.Length);
            float minTime = 7.0f;
            float maxtime = 9.0f;
            float randomTime = Random.Range(minTime, maxtime);  

            Instantiate(obstacles[RandomIndex], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }

    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
