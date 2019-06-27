using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    [SerializeField]
    private Transform m_frontTransform;
    [SerializeField]
    private Transform m_rearTransform;

    private void Awake()
    {

        m_frontTransform = this.gameObject.transform.GetChild(0).transform;
        m_rearTransform = this.gameObject.transform.GetChild(1).transform;

    }

    private void Update()
    {

        m_frontTransform.position = m_frontTransform.position + m_frontTransform.localScale / 2;
        m_rearTransform.position = m_rearTransform.position - m_rearTransform.localScale / 2;

    }

}
