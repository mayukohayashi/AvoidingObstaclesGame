using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  [SerializeField] float moveSpeed = 10f;

  // Start is called before the first frame update
  void Start()
  {
    PrintInstructions();
  }

  // Update is called once per frame
  void Update()
  {
    MovePlayer();
  }

  void PrintInstructions()
  {
    Debug.Log("Welcome to the sparrow game");
    Debug.Log("Move your player with WASD or arrow keys");
    Debug.Log("Escape from the obstacles. Don't hit the walls!");
  }

  void MovePlayer()
  {
    float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
    float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
    transform.Translate(x, 0, z);
  }

}
