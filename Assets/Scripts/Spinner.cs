using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
  [SerializeField] float rotateX = 0f;
  [SerializeField] float rotateY = 0f;
  [SerializeField] float rotateZ = 0f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(rotateX, rotateY, rotateZ);
  }
}
