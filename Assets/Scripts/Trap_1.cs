using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_1 : MonoBehaviour
{
    public float gravityScale = 2f; // 중력 강도 배율

    private Rigidbody2D Rigid;

    private void Awake()
    {
        Rigid = GetComponent<Rigidbody2D>();
        // 중력 강도 설정
        Rigid.gravityScale = gravityScale;
    }
}
