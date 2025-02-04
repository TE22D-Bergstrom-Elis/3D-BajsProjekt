using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  Animator animator;
  CharacterController characterController;
  bool walking = false;
  Vector2 moveInput = Vector2.zero;
  [SerializeField]
  float speed = 5;

  [SerializeField]
  float rotationSpeed = 180;

  void Start()
  {
    animator = GetComponent<Animator>();
    characterController = GetComponent<CharacterController>();
  }

  void Update()
  {
    transform.Rotate(Vector3.up, moveInput.x * rotationSpeed * Time.deltaTime);

    Vector3 movement = transform.forward * moveInput.y;

    if (movement.magnitude > 0)
    {
      animator.SetBool("moving", true);
    }
    else
    {
      animator.SetBool("moving", false);
    }

    characterController.Move(movement * speed * Time.deltaTime);

    // transform.Translate(moveInput * speed * Time.deltaTime);
  }

  void OnMove(InputValue value)
  {
    moveInput = value.Get<Vector2>();
  }
}
