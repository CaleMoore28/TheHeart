using UnityEngine;

public class NavFollowPlayer : MonoBehaviour
{
  [SerializeField] Transform cameraTransform;
  [SerializeField] float smoothSpeed = 5f;

  void Update()
  {
    if (cameraTransform == null) return;

    // following Y axis
    float targetYRotation = cameraTransform.eulerAngles.y;

    float smoothY = Mathf.LerpAngle(
        transform.eulerAngles.y,
        targetYRotation,
        Time.deltaTime * smoothSpeed
    );

    transform.rotation = Quaternion.Euler(0, smoothY, 0);
  }
}
