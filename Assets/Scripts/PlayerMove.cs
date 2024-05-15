using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private List<Transform> posPointMove = new List<Transform>();
    [SerializeField,Min(0)] private int indexDir;
    [SerializeField] private float speed,distanse;

    private void Update()
    {
        switch (ControllerGame.isPause)
        {
            case true:
                break;
            case false:
                Move();
                distanse = Vector2.Distance(player.position, posPointMove[indexDir].position);
                if (Input.GetMouseButtonDown(0) || distanse <= 0.1f) newDirPos();
                break;
        }
    }

    private void newDirPos()
    {
        indexDir++;
        indexDir = indexDir % posPointMove.Count;
    }

    private void Move()
    {
        player.position = Vector2.MoveTowards(player.position, posPointMove[indexDir].position, speed * Time.deltaTime);
    }
}
