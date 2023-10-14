using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_IRPlayer : MonoBehaviour
{
    public float gravity = 20.0f;
    public float jumpHeight = 2.5f;
    public float moveSpeed = 80;

    Rigidbody r;
    bool grounded = false;
    Vector3 defaultScale;
    bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        //r.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        r.freezeRotation = true;
        //r.useGravity = false;
        defaultScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && grounded)
        {
            r.velocity = new Vector3(r.velocity.x, CalculateJumpVerticalSpeed(), r.velocity.z);
        }

        crouch = Input.GetKey(KeyCode.S);
        if (crouch)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(defaultScale.x, defaultScale.y * 0.4f, defaultScale.z), Time.deltaTime * 7);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, defaultScale, Time.deltaTime * 7);
        }
    }

    private void FixedUpdate()
    {
        //r.AddForce(new Vector3(0, -gravity * r.mass, 0));
        grounded = false;
        Debug.Log(Input.GetAxis("Horizontal"));
        r.AddForce(transform.right * Input.GetAxis("Horizontal") * moveSpeed);
    }

    private void OnCollisionStay(Collision collision)
    {
        grounded = true;
    }

    float CalculateJumpVerticalSpeed()
    {
        return Mathf.Sqrt(2 * jumpHeight * gravity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            SC_GroundGenerator.instance.gameOver = true;
        }
    }
}
