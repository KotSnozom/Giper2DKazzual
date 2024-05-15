using UnityEngine;

public class GetCoin : MonoBehaviour
{
    public int coinCount;
    [SerializeField] private string coinTag;
    [SerializeField] private int coinAddScore;
    [Header("�������")]
    [SerializeField] private SpawnCoin spawnCoin;
    [SerializeField] private UIManager uiM;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.CompareTag(coinTag))
        {
            coinCount += coinAddScore;
            uiM.UpdateScore(coinCount);
            string name = coll.transform.parent.gameObject.name;
            Destroy(coll.gameObject);
            foreach (var namePoint in spawnCoin.defCoins)
            {
                if (name == namePoint.name) namePoint.isFree = true;
            }
        }
    }
}
