using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHits : MonoBehaviour
{

  private void OnCollisionEnter(Collision other)
  {

    // Debug.Log("Sparrow hits");
    if (other.gameObject.tag == "Player")
    {
      GetComponent<MeshRenderer>().material.color = Color.red;
      gameObject.tag = "Hit";
    }

  }

}
