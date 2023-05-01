using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    private float time;
    private int points;

    [SerializeField] private TMP_Text pointsText;
    [SerializeField] private TMP_Text pointsGameOverText;

    private void Update()
    {
        time += Time.deltaTime;
        points = (int)(time * 5);

        pointsText.text = points.ToString("000000");
        pointsGameOverText.text = points.ToString("000000");
    }
}