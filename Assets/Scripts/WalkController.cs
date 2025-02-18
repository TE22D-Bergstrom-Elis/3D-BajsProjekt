using UnityEngine;
using UnityEngine.InputSystem;

public class WalkController : MonoBehaviour
{
  Vector2 moveInput;
  [SerializeField]
  float walkSpeed = 5;

  float velocityY = 0;

  CharacterController controller;

  void Start()
  {
    controller = GetComponent<CharacterController>();
  }

  void Update()
  {
    velocityY += Physics.gravity.y * Time.deltaTime;

    if (controller.isGrounded)
    {
      velocityY = 0;
    }

    Vector3 movement =
      transform.right * moveInput.x
      + transform.forward * moveInput.y;

    movement.y = velocityY;

    controller.Move(
      Time.deltaTime * walkSpeed * movement);
  }

  void OnMove(InputValue value) => moveInput = value.Get<Vector2>();
}
