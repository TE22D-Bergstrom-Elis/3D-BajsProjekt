using UnityEngine;
using UnityEngine.InputSystem;

public class LookController : MonoBehaviour
{
  Camera head;
  Vector2 lookInput;

  [SerializeField]
  Vector2 sensitivity = Vector2.one;

  void Start()
  {
    head = GetComponentInChildren<Camera>();
    Cursor.lockState = CursorLockMode.Locked;
  }

  void Update()
  {
    transform.Rotate(Vector3.up, lookInput.x * sensitivity.x);
    head.transform.Rotate(Vector3.right, lookInput.y * sensitivity.y);
  }

  void OnLook(InputValue value)
  {
    lookInput = value.Get<Vector2>();
  }
}
