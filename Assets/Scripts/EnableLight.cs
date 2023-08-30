using UnityEngine;

public class EnableLight : MonoBehaviour
{
  public Light _mainLight;

  private void Update() 
  {
    if (Input.GetKeyUp(KeyCode.T))   /// Input - функция отвечает за кнопку. GetKeyUp - пользователь отпускает клавишу (KeyCode.T) - Назначить клавишу T. Так же есть GetKeyDown (зажатие кнопки)
    //   _mainLight.enabled = false;   // enable - активность переменной , булевой тип
    _mainLight.enabled = !_mainLight.enabled;
  }
}
