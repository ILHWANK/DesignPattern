using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject enemy;
    public int poolSize = 10;
    GameObject[] enemyPool;

    void Start()
    {
        enemyPool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; ++i)
        {
            enemyPool[i] = Instantiate(enemy) as GameObject;
            enemyPool[i].name = "Enemy_" + i;
            enemyPool[i].SetActive(false);
        }

        StartCoroutine("SpawnManager");
    }

    IEnumerator SpawnManager()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);

            for (int i = 0; i < poolSize; i++)
            {
                if (enemyPool[i].activeSelf == true)
                    continue;

                float x = Random.Range(-4, 5);
                float z = Random.Range(-4, 5);

                enemyPool[i].transform.position = new Vector3(x, 0.5f, z);
                enemyPool[i].SetActive(true);

                break;
            }
        }
    }
}
