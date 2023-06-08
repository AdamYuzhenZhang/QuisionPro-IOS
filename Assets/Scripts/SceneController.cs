using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // stores the left eye and right eye
    private GameObject m_LeftEye;
    private GameObject m_RightEye;
    public GameObject LeftEye
    {
        get => m_LeftEye;
        set => m_LeftEye = value;
    }
    public GameObject RightEye
    {
        get => m_RightEye;
        set => m_RightEye = value;
    }

    [SerializeField] private GameObject m_ViewerCamRoot;

    private void Update()
    {
        // move camera to left eye if it exists
        if (LeftEye)
        {
            m_ViewerCamRoot.transform.position = LeftEye.transform.position;
            m_ViewerCamRoot.transform.rotation = LeftEye.transform.rotation;
        }
    }
}
