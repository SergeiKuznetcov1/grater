using UnityEngine;

public class GrateDetectorPlacer : MonoBehaviour
{
	[SerializeField] private SpriteRenderer _curImage;
    [SerializeField] private Transform _grateDetector;
    private void Update() {
        MoveGrateDetector();
    }
    public void MoveGrateDetector() {
        _grateDetector.localPosition = new Vector3(_curImage.localBounds.center.x, 
            _curImage.localBounds.center.y - _curImage.localBounds.size.y / 2 + 0.2f + _curImage.transform.localPosition.y);
    }
}
