using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Example 1
 */
public class CExample_01 : MonoBehaviour
{
    public GameObject m_oPrefabCube = null;

    /** �ʱ�ȭ */
    public void Awake()
    {
        Debug.Log("Hello, World!");
    }

    /** ���¸� �����Ѵ� */
    public void Update()
    {
        // �����̽� Ű�� ������ ���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(m_oPrefabCube, 
                Vector3.zero, Quaternion.identity);
        }
    }
}
