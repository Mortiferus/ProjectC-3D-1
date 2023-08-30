using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBarrel : MonoBehaviour
{
 public GameObject[] Barrels = new GameObject[1];  // Переменная является массивом типа GameObject
 public Transform[] transforms = new Transform[1];
 public float speed = 1.0f, rotatespeed = 30f;

    // Update is called once per frame
    private void Start()    // Отвечает за запуск игры
    {
   
    }
    private void Update()    //Постоянное обновление после старта (40 фреймов в секунду)
    {
   for (int i=0; i < transforms.Length;i++)
       {
         rotatespeed = 30f;
         if (transforms[i] == null)
               return;
          transforms[i].Rotate(new Vector3(1,0,0) * rotatespeed * Time.deltaTime);
          float posX = transforms[i].rotation.x;
          if (posX > 20f && transforms[i].gameObject.name == "Barrel")

        }
    }

   public void BarrelDown()
    {

    }


}
