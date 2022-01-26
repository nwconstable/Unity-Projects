using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float lifeTime;
    [SerializeField] private Transform mainTransform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireRoutine());
        IEnumerator FireRoutine() {
            float elapsedTime = 0;
            while(elapsedTime <= lifeTime) {
                elapsedTime += Time.deltaTime;
                mainTransform.position += mainTransform.up * speed * Time.deltaTime;
                yield return null;
            }
            Destroy(gameObject);
        }
    }
}
