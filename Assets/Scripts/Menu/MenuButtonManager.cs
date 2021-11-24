using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonManager : MonoBehaviour
{
    public List<GameObject> Buttons;

    [Header("animation")]
    public float duration = .2f;
    public float delay = .05f;
    public Ease ease = Ease.OutBack;

    private void Awake()
    {
        HideAllButtons();
        ShowButtons();
    }

    private void HideAllButtons()
    {
        foreach (var b in Buttons)
        {
            b.transform.localScale = Vector3.zero;
            b.SetActive(false);
        }
    }

    private void ShowButtons()
    {
        for(int i = 0; i < Buttons.Count; i++)
        {
            var b = Buttons[i];
            b.SetActive(true);
            b.transform.DOScale(1, duration).SetDelay(1 * delay).SetEase(ease);
        }
    }
}
