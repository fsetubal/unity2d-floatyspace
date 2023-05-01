using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour

{
    [SerializeField] private EnemyWeight[] enemies;

    private int totalWeights;

    // Start is called before the first frame update
    void Start()
    {
        foreach(EnemyWeight i in enemies)
        {
            totalWeights += i.weight;
        }

        StartCoroutine(GenerateEnemies());
    }

    private IEnumerator GenerateEnemies()
    {
        while(true)
        {
            int enemyAmount = Random.Range(1, 4);


            for(int i=0; i<enemyAmount; i++)
            {
                Instantiate(GetEnemy(), new Vector3(Random.Range(3.5f, 7.5f), Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);
            }
            
            yield return new WaitForSeconds(3f);
        }
    }

    private GameObject GetEnemy()
    {
        int sortNumber = Random.Range(0, totalWeights) + 1;
        int processedWeight = 0;

        for(int i= 0; i < enemies.Length; i++)
        {
            processedWeight += enemies[i].weight;

            if(sortNumber <= processedWeight)
            {
                return enemies[i].enemy;
            }
        }

        return null;
    }
}
