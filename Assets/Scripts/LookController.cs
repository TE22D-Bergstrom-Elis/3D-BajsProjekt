using UnityEngine;
using UnityEngine.InputSystem;

public class LookController : MonoBehaviour
{
  Camera head;
  Vector2 lookInput;

  [SerializeField]
  Vector2 sensitivity = Vector2.one;

  float xRotation = 0;

  void Start()
  {
    head = GetComponentInChildren<Camera>();
    Cursor.lockState = CursorLockMode.Locked;
  }

  void Update()
  {
    xRotation += lookInput.y * sensitivity.y;
    xRotation = Mathf.Clamp(xRotation, -90, 90);

    head.transform.localEulerAngles = new(
      xRotation, 0, 0
    );

    transform.Rotate(Vector3.up, lookInput.x * sensitivity.x);

    print(Physics.Raycast(
      head.transform.position,
      head.transform.forward)
      );

  }

  void OnLook(InputValue value)
  {
    lookInput = value.Get<Vector2>();
  }
}
