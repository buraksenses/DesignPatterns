using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

namespace Patterns.Object_Pooling
{
    public class Enemy : MonoBehaviour
    {
        private IObjectPool<Enemy> _enemyPool;
        
        public void SetPool(IObjectPool<Enemy> pool)
        {
            _enemyPool = pool;
        }
        
        private void Update()
        {
            transform.position+=Vector3.one * (Time.deltaTime * 1f);
        }

        private IEnumerator DestroyObject()
        {
            yield return new WaitForSeconds(2f);
            _enemyPool.Release(this);
        }

        private void OnEnable()
        {
            StartCoroutine(DestroyObject());
        }
    }
}
