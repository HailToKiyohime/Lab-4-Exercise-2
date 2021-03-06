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
    public void AddScore(int value)
    {
        Value += value;
        _text.text = "Score: "+Value.ToString();
    }

}
