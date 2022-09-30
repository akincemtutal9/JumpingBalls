using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jumpSpeed;

    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void JumpForce()
    {
        rb.AddForce(Vector3.up * jumpSpeed , ForceMode.Impulse);
    }
}
