using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

  int hits = 0;

  private void OnCollisionEnter(Collision other)
  {

    hits++;
    Debug.Log("すずめが何者かと接触してしまった…： " + hits + "回目");

  }
}
