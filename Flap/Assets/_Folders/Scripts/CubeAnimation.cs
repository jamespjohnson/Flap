using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    void fall()
    {
        transform.DOMoveY(transform.localPosition.y - 1.5f, 1f, false).SetAutoKill(true);
    }
    void jump()
    {
       transform.DOMoveY(transform.localPosition.y + 10f, 1f, false).SetAutoKill(true);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            jump();
        fall();
    }
}
