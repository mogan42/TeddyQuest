using UnityEngine;
using System.Collections;

public class ObjectSpin : MonoBehaviour
{
    public float spinSpeed = 25.0f;
    public float maxUpAndDown = 0.1f;
    public float Speed = 50;
    private float angle = -90;
    private float toDegrees = Mathf.PI / 180;
    private float startHeight;

    void Start()
    {
        startHeight = transform.localPosition.y;
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * spinSpeed);
        angle += Speed * Time.deltaTime;
        if (angle > 270) angle -= 360;
        transform.localPosition = new Vector3(transform.localPosition.x, startHeight + maxUpAndDown * (1 + Mathf.Sin(angle * toDegrees)), transform.localPosition.z);
    }
}
