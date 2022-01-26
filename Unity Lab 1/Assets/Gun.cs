using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private Transform gunTransform;
    [SerializeField] private Transform shootPosition;
    [SerializeField] private float rotationSpeed = 100f;
    [SerializeField] private GameObject[] bullets;

    // Update is called once per frame
    void Update()
    {
        // Rotate the gun
        gunTransform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
        // Check if user has pressed space key (or mouse button)
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            Fire();
        }
    }

    private void Fire() {
        // Instantiate a bullet
        GameObject bulletPrefab = bullets[Random.Range(0, bullets.Length)];
        GameObject newBullet = Instantiate(bulletPrefab);
        // Set the bullet's position
        newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
    }
}
