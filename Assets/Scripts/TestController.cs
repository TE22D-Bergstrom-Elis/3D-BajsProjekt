using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestController : MonoBehaviour
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
    Vector3 movement = Camera.main.transform.right * moveInput.x + 
    Camera.main.transform.forward * moveInput.y;




    if (moveInput.magnitude > 0)
    {
      movement.y = 0;
      animator.SetBool("moving", true);
      movement.Normalize();
      transform.forward = movement;
    }
    else
    {
      animator.SetBool("moving", false);
    }

    GetComponent<CharacterController>().Move(movement * speed * Time.deltaTime);

    // transform.Translate(movement * speed * Time.deltaTime);


    // transform.Rotate(transform.up, moveInput.x);

  }

  void OnMove(InputValue value)
  {
    moveInput = value.Get<Vector2>();
  }
}
