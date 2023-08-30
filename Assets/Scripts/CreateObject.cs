
using UnityEngine;

public class CreateObject : MonoBehaviour
{
   public GameObject[] obj;

     private void Start()
     {
    //    for (int i = 0; i < 5; i++)
    //    {
    //         Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNumber(),RandomNumber(),RandomNumber()), Quaternion.Euler(12f,-15f,40f));  // Instantiate - создание объекта с параметрами
    //    }
       // GameObject newObject = Instantiate(obj, new Vector3(0,5,0), Quaternion.Euler(12f,-15f,40f)) as GameObject;
       // newObject.GetComponent<Transform>().position= new Vector3(10,0,0);
     }
     private int RandomNumber()   // Создание метода с рандомными числами
     {
        return Random.Range(0, 10);
     }
 
}
