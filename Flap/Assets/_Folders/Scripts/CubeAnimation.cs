using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    float gravity = -6.0f;
    void Fall()
    {
        Vector3 pos = transform.localPosition;
        pos.y += gravity * Time.deltaTime;
        transform.localPosition = pos;
    }

    void Jump()
    {
        transform.DOKill(false);
        transform.DOMoveY(transform.localPosition.y + 1.5f, 0.15f).SetEase(Ease.OutBack);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            Jump();
        Fall();
    }
}
