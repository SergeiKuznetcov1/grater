using UnityEngine;

public class ImageObjPlacer : MonoBehaviour
{
    private Sprite _firstSprite;
	private void Start() {
        _firstSprite = GetComponent<SpriteRenderer>().sprite;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.position.z);
    }
}
