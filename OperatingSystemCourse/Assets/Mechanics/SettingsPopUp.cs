using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class SettingsPopUp : MonoBehaviour
{
    public event Action onShowComplete;
    public event Action onHideComplete;
    [Header("AnimationInformation")]
    [SerializeField] private float time;

    private Image[] images;
    void Start()
    {
        images = gameObject.GetComponentsInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        foreach(var image in images)
        {
            image.DOFade(1, time).onComplete += () => onShowComplete?.Invoke();
        }
    }

    public void Hide()
    {
        foreach (var image in images)
        {
            image.DOFade(0, time).onComplete += () => onHideComplete?.Invoke();
        }
        onHideComplete += () => gameObject.SetActive(false);
    }
}
