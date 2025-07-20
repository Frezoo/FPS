using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject enemy;


   
    void Update()
    {
        if (enemy == null)
        {
            enemy = (GameObject)Instantiate(enemyPrefab);
            enemy.transform.position = new Vector3(0, -0.92f, 0);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
        }
    }
}
