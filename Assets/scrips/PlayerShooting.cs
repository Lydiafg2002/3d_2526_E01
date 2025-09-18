using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
   public GameObject bulletPrefab;
    public Transform bulletOrigin;

    public AudioSource shootSound;

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject newbullet = Instantiate(bulletPrefab, bulletOrigin.position, Quaternion.identity);
             newbullet.transform.forward = gameObject.transform.forward;
            shootSound .pitch = Random.Range(6f, 1f);
            shootSound.Play();
        }
       

    }
}
