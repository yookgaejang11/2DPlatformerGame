using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_3 : MonoBehaviour
{
    public int Speed;
    private void FixedUpdate()
    {
        
        transform.Translate(-1 * Speed, 0, 0);
    }
    

}
