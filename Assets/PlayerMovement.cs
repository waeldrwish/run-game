using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwordFroce = 400f;
    public float horizontalFroce = 400f;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwordFroce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(horizontalFroce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-horizontalFroce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
