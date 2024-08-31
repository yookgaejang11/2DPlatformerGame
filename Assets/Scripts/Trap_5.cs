using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_5 : MonoBehaviour
{
    public int Speed;
    private void FixedUpdate()
    {
        transform.Translate(0, 1 * Speed, 0);
    }
}
