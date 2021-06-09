using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalTween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(transform.localPosition.x - 15, 5.0f).SetLoops(-1, LoopType.Yoyo);
    }
}
