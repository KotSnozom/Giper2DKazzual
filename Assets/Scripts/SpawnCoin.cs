using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DefCoins
{
    public string name;
    public Transform spawnPoint;
    public bool isFree;
}

public class SpawnCoin : MonoBehaviour
{
    [SerializeField] private GameObject coins;
    [SerializeField] private float timeToSpawn,MinX,MaxX;
    public List<DefCoins> defCoins = new List<DefCoins>();
    [Header("�������")]
    [SerializeField] private PlayerMove Pmove;

    private void Awake()
    {
        StartCoroutine(SpawnCoins());
    }
    IEnumerator SpawnCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToSpawn);
            foreach (DefCoins coin in defCoins)
            {
                if(coin.isFree == true)
                {
                    Transform newCoin = Instantiate(coins, coin.spawnPoint.position, Quaternion.identity).GetComponent<Transform>();
                    newCoin.parent = coin.spawnPoint;
                    coin.isFree = false;
                    newPosPoint(coin);
                }
            }
        }
    }
    private void newPosPoint(DefCoins pos)
    {
        float randX = Random.Range(MinX, MaxX);
        pos.spawnPoint.position = new Vector2(randX, pos.spawnPoint.position.y);
    }
}
