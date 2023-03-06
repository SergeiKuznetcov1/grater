using UnityEngine;

public class GrateDetectorManager : MonoBehaviour
{
    [SerializeField] private GameObject _spritesObj;
    [SerializeField] private float _grateStep;
    private SpriteRenderer _spritesSR;
    private SpritesToGrate _spritesToGrate;
    private GrateTracker _grateTracker;
    private void Start() {
        _grateTracker = GetComponentInChildren<GrateTracker>();
        _spritesSR = _spritesObj.GetComponent<SpriteRenderer>();
        _spritesToGrate = _spritesObj.GetComponent<SpritesToGrate>();
    }
    private void Update() {
        int curSpriteIndex = (int)(_grateTracker.PassedDistance / _grateStep);
        if (curSpriteIndex <= _spritesToGrate.AllSprites.Length - 1) 
            _spritesSR.sprite = _spritesToGrate.AllSprites[curSpriteIndex];
        if (curSpriteIndex >= _spritesToGrate.AllSprites.Length - 1)
            _spritesSR.sprite = null;
    }
}
