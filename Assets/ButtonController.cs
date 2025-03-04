using UnityEngine;

public class ButtonController : MonoBehaviour
{
  [SerializeField]
  GameObject interactable;

  public void Press()
  {
    print("Help! I'm being oppressed!");
    Destroy(interactable);
  }
}