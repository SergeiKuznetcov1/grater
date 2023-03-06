using UnityEngine;

public class GrateTracker : MonoBehaviour
{
    private float _preLocationY;
    private float _curLocationY;
    public float PassedDistance { get; private set; }
    private MoveDirection _curMoveDir;
    private enum MoveDirection { Up, Down }
    private void OnTriggerEnter2D(Collider2D other) {
        _curLocationY = Input.mousePosition.y;
        _preLocationY = _curLocationY;
    }
	private void OnTriggerStay2D(Collider2D other) {
        HandleMovement();
    }

    private void AddToDistance() {
        if (_curMoveDir == MoveDirection.Down) 
            PassedDistance += (_preLocationY - _curLocationY) / 5;
    }

    private void HandleMovement() {
        _curLocationY = Input.mousePosition.y;
        CheckMoveDirection();
        AddToDistance();
        Debug.Log(PassedDistance);
        _preLocationY = _curLocationY;
    }

    private void CheckMoveDirection() {
        if (_preLocationY > _curLocationY) 
            _curMoveDir = MoveDirection.Down;
        else if (_preLocationY < _curLocationY) 
            _curMoveDir = MoveDirection.Up;
    }
}
