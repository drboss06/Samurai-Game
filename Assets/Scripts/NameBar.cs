using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameBar : MonoBehaviour
{
    public TextMeshProUGUI title;
    [SerializeField] private Vector3 _offset;
    public StaticEnemy enemy;
    void Start()
    {
        title.text = enemy.enemyName;
    }

    void Update()
    {
        title.transform.position = Camera.main.WorldToScreenPoint(enemy.transform.position + _offset);
    }
}
