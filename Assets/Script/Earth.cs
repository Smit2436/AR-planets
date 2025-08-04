using UnityEngine;

public class Earth : MonoBehaviour
{
    public GameObject Planetobject;
    public Vector3 RotationVector;
    void Update()
    {
        Planetobject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
