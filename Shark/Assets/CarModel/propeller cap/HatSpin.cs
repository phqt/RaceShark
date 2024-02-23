using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HatSpin : MonoBehaviour
{
    public float spinDuration;

    void Start()
    {
        //transform.DORotate(new Vector3(0, 360, 0), spinDuration, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        transform.DORotate(new Vector3(0, 360, 0), spinDuration).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }
}
