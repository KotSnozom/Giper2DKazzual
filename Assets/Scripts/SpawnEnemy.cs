using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<Transform> posEnemySpawn = new List<Transform>();
    public float MinTime,MaxTime;

    public void GenerateSpawnEnemy()
    {
        StartCoroutine(SpawnsEnemy());
        IEnumerator SpawnsEnemy()
        {
            while (true)
            {
                yield return new WaitForSeconds(Random.Range(MinTime, MaxTime));
                int randPos = Random.Range(0, posEnemySpawn.Count);
                EnemyMove enemyCS = Instantiate(enemyPrefab, posEnemySpawn[randPos].position + RandPos(), Quaternion.identity).GetComponent<EnemyMove>();
                enemyCS.ParentPoint = posEnemySpawn[randPos];
            }
        }
    }
    public Vector3 RandPos()
    {
        Vector3 randVector = new Vector3(0,Random.Range(-3,3),0);
        return randVector;
    }
}
