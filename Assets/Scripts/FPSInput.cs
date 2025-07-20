using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float Speed;
    private float gravity = -9.8f;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

  
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * Speed;
        float deltaZ = Input.GetAxis("Vertical") * Speed;

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, Speed) * Time.deltaTime;
        movement.y = gravity;

        movement = transform.TransformDirection(movement);
        

        characterController.Move(movement);
    }
}
