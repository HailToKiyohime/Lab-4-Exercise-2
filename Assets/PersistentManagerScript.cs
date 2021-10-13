using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistentManagerScript : MonoBehaviour
{
    public int Value;
    private Text _text;

    public static PersistentManagerScript Instance {get; private set;}

    private void Awake()
    {
        _text = GetComponent<Text>();
        Instance = this;
    }
    public void AddScore(int value)
    {
        Value += value;
        _text.text = "Score: "+Value.ToString();
    }

}
