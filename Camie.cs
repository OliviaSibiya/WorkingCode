using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camie : MonoBehaviour
{
     Camera m_MainCamera;
     public Camera m_CameraTwo;

    public Transform target;
    public float smotthSpeed = 0.1f;
    public Vector3 offset;
     

    // Start is called before the first frame update
    void Start()
    {
        m_MainCamera = Camera.main;
        m_MainCamera.enabled = true;
        m_CameraTwo.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (m_MainCamera.enabled)
            {
                m_CameraTwo.enabled = true;
                m_MainCamera.enabled = false;
            }

            else if (!m_MainCamera.enabled)
            {
                m_CameraTwo.enabled = false;
                m_MainCamera.enabled = true;
            }
        }
    }

    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
