using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float Speed = 5;
    public float SphereRadius = 0.75f;
    public float obstacleRange = 3;

    private bool alive = true;

    [SerializeField] private GameObject fireballPrefab;
    private GameObject fireball;

    void Update()
    {
        if (alive)
        {
            transform.Translate(0, 0, Speed * Time.deltaTime);
        }
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, SphereRadius, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            if (hitObject.GetComponent<PlayerCharacter>() != null)
            {
                if (fireball == null)
                {
                    Debug.Log("13");
                    fireball = (GameObject)Instantiate(fireballPrefab);
                    fireball.transform.position =  transform.position + transform.forward * 1.5f;
                    fireball.transform.rotation = transform.rotation;

                }
            }
            if (hit.distance < obstacleRange  && hitObject.GetComponent<Fireball>() == null)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
           
        }
    }

    public void SetAlive(bool alive)
    {
        this.alive = alive;
    }
}
