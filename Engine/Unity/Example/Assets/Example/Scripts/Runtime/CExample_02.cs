using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CExample_02 : MonoBehaviour
{
    [SerializeField] private float m_fPower = 0.0f;
    private float m_fAngle = 0.0f;

    [SerializeField] private GameObject m_oCube = null;

    /** �ʱ�ȭ */
    public void Awake()
    {
        Physics.gravity = new Vector3(0.0f, -981.0f, 0.0f);
    }

    /** ���¸� �����Ѵ� */
    public void Update()
    {
        // ���� ���� Ű�� ������ ���
        if (Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow))
        {
            float fDirection = Input.GetKey(KeyCode.UpArrow) ? 
                1.0f : -1.0f;

            m_fAngle += (90.0f * fDirection) * Time.deltaTime;
            m_fAngle = Mathf.Clamp(m_fAngle, 0.0f, 90.0f);

            m_oCube.transform.eulerAngles = new Vector3(0.0f, 
                0.0f, m_fAngle);
        }

        // �߻� Ű�� ������ ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var oRigidbody = m_oCube.GetComponent<Rigidbody>();
            oRigidbody.isKinematic = false;

            oRigidbody.AddForceAtPosition(m_oCube.transform.right * m_fPower,
                m_oCube.transform.position + Vector3.up * 50.0f, ForceMode.VelocityChange);
        }
    }
}
