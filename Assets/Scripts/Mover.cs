using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  [SerializeField] float x = 0f;
  [SerializeField] float y = 0.02f;
  [SerializeField] float z = 0;

  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(x, y, z);
  }
}
