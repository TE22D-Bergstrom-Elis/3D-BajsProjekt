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

  void Start()
  {
    animator = GetComponent<Animator>();
    characterController = GetComponent<CharacterController>();
  }

  void Update()
  {
    Vector3 movement = Camera.main.transform.right * moveInput.x
                     + Camera.main.transform.forward * moveInput.y;

    if (movement.magnitude > 0)
    {
      movement.y = 0;
      movement.Normalize();
      transform.forward = movement;
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
