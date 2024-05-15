using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed,rotateSpeed;
    public Transform squad;
    public Transform ParentPoint;
    private void Update()
    {
        Move(ParentPoint);
        RotateEnemy();
    }
    public void Move(Transform Parent)
    {
        transform.Translate((Parent.forward * speed)  * Time.deltaTime);
    }
    private void RotateEnemy()
    {
        squad.Rotate((transform.forward * rotateSpeed) * Time.deltaTime);
    }
}
