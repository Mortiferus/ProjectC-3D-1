using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
   public float vSpeed = 45f, hSpeed = 35f, _thrust = 500f ;
   private  Rigidbody  _rb;

   private void Awake() 
   {
    _rb = GetComponent<Rigidbody>();
   }

   private void Update()
   {
     // if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
      //  transform.Translate( new Vector3(1,0,0) * Time.deltaTime  * speed);

     // if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
     //   transform.Translate( new Vector3(1,0,0) * Time.deltaTime  * -speed);

    //   float v = Input.GetAxis("Vertical");
    //   transform.Translate( new Vector3(1,0,0) * Time.deltaTime  * speed * v);

    //  float z = Input.GetAxis("Horizontal");
   //    transform.Translate( new Vector3(0,0,1) * Time.deltaTime  * speed * z);
    }

    private void FixedUpdate()     // Использовать для физики 
    {
      float h = Input.GetAxis("Horizontal") * hSpeed * Time.fixedDeltaTime;
      float v = Input.GetAxis("Vertical") * vSpeed * Time.fixedDeltaTime;

      _rb.velocity = transform.TransformDirection(new Vector3(v, _rb.velocity.y , -h));
    }
    private void OnCollisionEnter(Collision other) // соприкосновение с объектами
    {
      if(other.gameObject.name == "Cube (1)" | other.gameObject.name == "Cube (2)" ) 
      _rb.AddForce(new Vector3(0,1,0) * _thrust); // AddForce сила толчка
    }

    private void OnCollisionStay(Collision other) // действие пока соприкосаемся с объектом
    {
      
    }
    private void OnCollisionExit(Collision other) // действие после соприкоснование с объектом
    {
      
    }
    private void OnTriggerEnter(Collider other) // Для работы с триггерами
    {
     
    }
    private void OnTriggerExit(Collider other) 
    {
      
    }
    private void OnTriggerStay(Collider other) {
      
    }
}
