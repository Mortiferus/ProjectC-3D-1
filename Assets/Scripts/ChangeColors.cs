using UnityEngine;

public class ChangeColors : MonoBehaviour
{
   private MeshRenderer _mesh;

    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    } 
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        _mesh.material.color = Color.green;
    }
}
