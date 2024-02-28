using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class StartGame : MonoBehaviour
{
    public GameObject titleCam;
    //public GameObject playerCam;
    public GameObject titleCanvas;
    public Image btn;
    public TMP_Text btnText;
    public TMP_Text titleOne;
    public TMP_Text titleTwo;

    public void Start()
    {
        titleCam.SetActive(false);
        btn.DOFade(0, 3f).SetEase(Ease.InOutSine);
        btnText.DOFade(0, 3f).SetEase(Ease.InOutSine);
        titleOne.DOFade(0, 3f).SetEase(Ease.InOutSine);
        titleTwo.DOFade(0, 3f).SetEase(Ease.InOutSine).OnComplete(() =>
            {
                titleCanvas.SetActive(false);
            });
    }
}
