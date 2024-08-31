using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_1 : MonoBehaviour
{
    public float gravityScale = 2f; // �߷� ���� ����

    private Rigidbody2D Rigid;

    private void Awake()
    {
        Rigid = GetComponent<Rigidbody2D>();
        // �߷� ���� ����
        Rigid.gravityScale = gravityScale;
    }
}
