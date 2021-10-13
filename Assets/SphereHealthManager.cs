using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereHealthManager : MonoBehaviour
{
    public int Value;
    private Text _text;

    public static SphereHealthManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            _text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void damage(int value)
    {
        Value -= value;
        _text.text = "Sphere Health: " + (10+Value).ToString();
    }

}
