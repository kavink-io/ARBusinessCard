using UnityEngine;

public class ARModelInteraction : MonoBehaviour
{
    public float moveSpeed = 0.0015f;
    public float zoomSpeed = 0.005f;

    public float minScale = 0.5f;
    public float maxScale = 2.5f;

    private float initialDistance;
    private Vector3 initialScale;

    void Update()
    {
        HandleTouch();
    }

    void HandleTouch()
    {
        // One finger = move model
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 delta = touch.deltaPosition;

                Vector3 rightMovement =
                    Camera.main.transform.right * delta.x * moveSpeed;

                Vector3 upMovement =
                    Camera.main.transform.up * delta.y * moveSpeed;

                transform.position += rightMovement + upMovement;
            }
        }

        // Two fingers = pinch zoom
        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            float currentDistance =
                Vector2.Distance(touch0.position, touch1.position);

            if (touch0.phase == TouchPhase.Began ||
                touch1.phase == TouchPhase.Began)
            {
                initialDistance = currentDistance;
                initialScale = transform.localScale;
            }

            if (initialDistance > 0f)
            {
                float difference =
                    currentDistance - initialDistance;

                float scaleChange =
                    difference * zoomSpeed;

                float newScale =
                    initialScale.x + scaleChange;

                newScale = Mathf.Clamp(
                    newScale,
                    minScale,
                    maxScale
                );

                transform.localScale =
                    Vector3.one * newScale;
            }
        }
    }
}