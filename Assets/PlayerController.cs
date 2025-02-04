using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  Animator animator;
  bool walking = false;
  Vector2 moveInput = Vector2.zero;
  [SerializeField]
  float speed = 5;

  void Start()
  {
    animator = GetComponent<Animator>();
  }

  void Update()
  {
    transform.Translate(moveInput * speed * Time.deltaTime);
  }

  void OnMove(InputValue value)
  {
    moveInput = value.Get<Vector2>();
  }
}
