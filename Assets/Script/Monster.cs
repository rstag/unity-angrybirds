using UnityEngine;

public class Monster : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Bird b = collision.collider.GetComponent<Bird>();
        if (b)
        {
            Destroy(gameObject);
            return;
        }

        Monster m = collision.collider.GetComponent<Monster>();
        if (m)
        {
            return;
        }

        if(collision.contacts[0].normal.y < -0.5)
        {
            Destroy(gameObject);
        }

    }
}
