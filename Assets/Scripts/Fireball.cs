using UnityEngine;

public class Fireball : MonoBehaviour
{
    private float speed = 10.0f;
    public int damage = 1;


    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.Hurt(damage);
        }


        Destroy(gameObject);


    }
}
