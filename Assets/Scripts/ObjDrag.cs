using UnityEngine;

public class ObjDrag : MonoBehaviour
{
    private Vector3 _mousePosOffset;
    private Vector3 GetObjPos() => Camera.main.WorldToScreenPoint(transform.position);

    private void OnMouseDown() {
            _mousePosOffset = Input.mousePosition - GetObjPos();
    }

    private void OnMouseDrag() {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - _mousePosOffset);    
    }
}
