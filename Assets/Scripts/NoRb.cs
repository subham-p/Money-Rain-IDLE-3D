using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRb : MonoBehaviour
{
    void FixedUpdate()
    {
        // rb.velocity += Physics.gravity * Time.fixedDeltaTime; // In PhysX, Acceleration ignores mass
        // float rigidbodyDrag = Mathf.Clamp01(1.0f - (rb.drag * Time.fixedDeltaTime));
        // rb.velocity *= rigidbodyDrag;
        // transform.position += rb.velocity * Time.fixedDeltaTime;
    }
}
