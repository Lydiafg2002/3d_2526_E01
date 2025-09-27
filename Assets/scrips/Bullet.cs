using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed;
    public Rigidbody rb;
    public GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Player");
        Destroy(gameObject, 5);
    }
    private void Update()
    {
        rb.linearVelocity = transform.forward * BulletSpeed;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Player.GetComponent<Score>().MorePoints(1);
            Destroy(other.gameObject);
        }
       
    }
}

