using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
  [SerializeField]
  GameObject ballPrefab;

  void Update()
  {
    for (int i = 0; i < 75; i++)
    {
      GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);

      Destroy(ball, 5000);
    }
  }
}
