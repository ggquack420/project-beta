using UnityEngine;

public class Camera : MonoBehaviour
{// ref https://learn.unity.com/tutorial/controlling-unity-camera-behaviour
    public Transform target;
    public Vector3 offset = new Vector3(0, 2, -14);

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;

            transform.rotation = Quaternion.Euler(0f, 360f, 0f);
        }
    }
}
