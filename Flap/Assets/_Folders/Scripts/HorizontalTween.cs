using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalTween : MonoBehaviour
{
    // Start is called before the first frame update
    void GoBack()
    {
        Vector3 pos = transform.localPosition;
        pos.x += 33;
        pos.y = Random.Range(1.5f, 6.5f);
        transform.localPosition = pos;
        transform.DOMoveX(transform.localPosition.x - 33, 1.5f).SetEase(Ease.Linear).OnComplete(GoBack).SetAutoKill(true);
    }

    void Start()
    {
        transform.DOMoveX(transform.localPosition.x - 33, 1.6f).SetEase(Ease.Linear).OnComplete(GoBack).SetAutoKill(true);
    }
}
