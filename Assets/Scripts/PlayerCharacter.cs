using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int health;
    private void Start()
    {
        health = 3;
    }

    public void Hurt(int damage)
    {
        health -= damage;
        Debug.Log("Health" + health);
    }
}
