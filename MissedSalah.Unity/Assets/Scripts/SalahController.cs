using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SalahController : MonoBehaviour
{
    [SerializeField] string _key;
    [SerializeField] Button _plus;
    [SerializeField] Button _minus;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] TextMeshProUGUI _text2;

    public void Plus()
    {
        var value = PlayerPrefs.GetInt(_key);
        value = Mathf.Clamp(++value, 0, 9999);
        PlayerPrefs.SetInt(_key, value);
    }
    public void Minus()
    {
        var value = PlayerPrefs.GetInt(_key);
        value = Mathf.Clamp(--value, 0, 9999);
        PlayerPrefs.SetInt(_key, value);
    }


    public void ValueSync()
    {
        _text.text = PlayerPrefs.GetInt(_key).ToString();
        _text2.text = _key;
    }
    private void Awake()
    {
        _plus.onClick.AddListener(() => Plus());
        _minus.onClick.AddListener(() => Minus());
        _plus.onClick.AddListener(() => ValueSync());
        _minus.onClick.AddListener(() => ValueSync());
        ValueSync();
    }

}
