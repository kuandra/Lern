using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgresBar : MonoBehaviour
{
    public Player Player;
    public Transform FinishPlaform;
    public Slider slider;

    private float _startY;
    private float _minY;

    private void Start()
    {
        _startY = Player.transform.position.y;
    }

    private void Update()
    {
        _minY = Mathf.Min(_minY, Player.transform.position.y);
        float currentY = Player.transform.position.y;
        float finishY = FinishPlaform.position.y;
        float t = Mathf.InverseLerp(_startY, finishY, _minY);
        slider.value = t;
    }
}
