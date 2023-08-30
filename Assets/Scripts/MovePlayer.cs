using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
   public float speed = 5f;

   private void Update()
   {
      if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        transform.Translate( new Vector3(1,0,0) * Time.deltaTime  * speed);

      if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        transform.Translate( new Vector3(1,0,0) * Time.deltaTime  * -speed);

    }
}
