using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _lifeTime;
    [SerializeField] private float _speed;

    private float _runningTime = 0f;

    private void Update()
    {
        transform.Translate(0, _speed * Time.deltaTime * -1, 0);

        if (_runningTime >= _lifeTime)
            Destroy(gameObject);

        _runningTime += Time.deltaTime;
    }
}
