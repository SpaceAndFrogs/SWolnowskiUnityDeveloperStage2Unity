
using UnityEngine;

public class Rotating : MonoBehaviour
{
    private Touch touch;

    private Vector2 touchPosition;

    private Quaternion rotationY;

    public float rotationSpeed;
 
    void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0f, touch.deltaPosition.x * rotationSpeed, 0f);

                transform.rotation *= rotationY;
            }
        }
    }
}
