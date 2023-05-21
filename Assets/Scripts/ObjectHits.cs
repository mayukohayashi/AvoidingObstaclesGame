using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHits : MonoBehaviour
{

  private void OnCollisionEnter(Collision other)
  {

    Debug.Log("Sparrow hits");
  }

}
