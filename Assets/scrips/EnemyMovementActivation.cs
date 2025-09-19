using Unity.Cinemachine;
using UnityEngine;

public class EnemyMovementActivation : MonoBehaviour
{
    public CinemachineSplineCart enemyCart;
    public float  enemyforwardSpeed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SetSpeed(enemyforwardSpeed);
        }
    }
    void SetSpeed(float z)
    {
        var autodolly = enemyCart.AutomaticDolly.Method as SplineAutoDolly.FixedSpeed;
        autodolly.Speed = z;
    }
}
