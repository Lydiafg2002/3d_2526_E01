using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float BulletSpeed;
    public Rigidbody rb;



    private void Start()
    {
        Destroy(gameObject, 5);
    }
    private void Update()
    {
        rb.linearVelocity = transform.forward * BulletSpeed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

           other.GetComponent<Health>().RepresentHealth(-10);
            Destroy(gameObject);
        }
    }
}
