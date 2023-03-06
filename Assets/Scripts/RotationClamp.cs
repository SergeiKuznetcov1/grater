using UnityEngine;

public class RotationClamp : MonoBehaviour
{
    private void Update() {
        if (transform.eulerAngles.z > 114.0f) {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 114.0f); 
        } 
        else if (transform.eulerAngles.z < 94.0f) {
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 94.0f); 
        }
    }
}
