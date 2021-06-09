using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimation : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveY(transform.localPosition.y + 5, 5.0f).SetLoops(-1, LoopType.Yoyo);
    }
}
