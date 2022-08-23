using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ApplicationController : MonoBehaviour
{

    [SerializeField] Transform _canvas;

    public void DoQuit()
    {
        _canvas.DOScale(Vector3.zero, 1).OnComplete(QuitApplication);
    }


    public void QuitApplication()
    {
        Debug.Log("Quited!");
        Application.Quit();
    }

    public void DevConnect()
    {
        Application.OpenURL("https://t.me/alkihuri");
    }

    public void OnApplicationQuit()
    {

    }
}
