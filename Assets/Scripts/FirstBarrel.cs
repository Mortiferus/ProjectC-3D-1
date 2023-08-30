using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBarrel : MonoBehaviour
{
<<<<<<< HEAD
 public GameObject[] Barrels = new GameObject[1];  // Переменная является массивом типа GameObject
 public Transform[] transforms = new Transform[1];
 public float speed = 1.0f, rotatespeed = 30f;
=======
 public GameObject[] Barrels = new GameObject[3];  // Переменная является массивом типа GameObject
 public Transform[] transforms = new Transform[3];
 public float speed = 1.0f, rotatespeed = 2f;
>>>>>>> refs/remotes/main/main

    // Update is called once per frame
    private void Start()    // Отвечает за запуск игры
    {
   
    }
    private void Update()    //Постоянное обновление после старта (40 фреймов в секунду)
    {
<<<<<<< HEAD
   for (int i=0; i < transforms.Length;i++)
       {
         rotatespeed = 30f;
         if (transforms[i] == null)
               return;
          transforms[i].Rotate(new Vector3(1,0,0) * rotatespeed * Time.deltaTime);
          float posX = transforms[i].rotation.x;
          if (posX > 20f && transforms[i].gameObject.name == "Barrel")

        }
=======
         for (int i=0; i < transforms.Length;i++)   // Вызов цикла
         {

            if (transforms[i] == null)
               continue;
            transforms[i].Translate(new Vector3(1,0,0) * speed * Time.deltaTime);    // Передвижение объекта
            transforms[i].Rotate(new Vector3(90,0,0) * rotatespeed * Time.deltaTime); // Вращение объекта

             float posX = transforms[i].position.x;                           // Создаём переменную и присваиваем ей позицию
            if (posX > 7f && transforms[i].gameObject.name == "Barrel")   // если posX будет больше 10 и наименование объекта массива равно = 'бочка'
               Destroy(transforms[i].gameObject);   // Уничтожить объект
         }
>>>>>>> refs/remotes/main/main
    }

   public void BarrelDown()
    {

    }


}
