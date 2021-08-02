using UnityEngine;

public class MonkeyMover : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private float rotationSpeed = 2f;
    private Transform monkeyTransform;

    public Transform Transform
    {
        get { return monkeyTransform; }
    }
    private void Awake()
    {
        monkeyTransform = gameObject.transform;
    }
    public void MoveToPosition(Vector3 newPosition)
    {
        monkeyTransform.position = newPosition;
    }
    public void RotateMonkey(float rotationInput)
    {
        if (Mathf.Abs(monkeyTransform.localEulerAngles.y) <= 90f || Mathf.Abs(monkeyTransform.localEulerAngles.y) >= 270f)
            RotateMonkeyByDirection(rotationInput);        
        else if (Mathf.Abs(monkeyTransform.localEulerAngles.y) > 90f && Mathf.Abs(monkeyTransform.localEulerAngles.y) < 180)
            RotateMonkeyByEulerAngles(new Vector3(monkeyTransform.localEulerAngles.x, 90, monkeyTransform.localEulerAngles.z));        
        else if (Mathf.Abs(monkeyTransform.localEulerAngles.y) > 180 && Mathf.Abs(monkeyTransform.localEulerAngles.y) < 270f)
            RotateMonkeyByEulerAngles(new Vector3(monkeyTransform.localEulerAngles.x, -90, monkeyTransform.localEulerAngles.z));
    }
    public void RotateMonkeyByDirection(float rotationDirection)
    {
        float rotation = 0;
        
        if (rotationDirection < 0)
            rotation = -rotationSpeed;        
        else if (rotationDirection > 0)
            rotation = rotationSpeed;
        
        monkeyTransform.Rotate(Vector3.up, rotation, Space.Self);
    }
    public void RotateMonkeyByEulerAngles(Vector3 inputVector)
    {
        monkeyTransform.localEulerAngles = inputVector;
    }

}
