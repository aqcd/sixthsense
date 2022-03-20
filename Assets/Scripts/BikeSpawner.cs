using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject bikePrefab;

    [SerializeField]
    public float spawnTimeMin = 1.0f;
    public float spawnTimeMax = 5.0f;

    private float spawnCooldown = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnCooldown -= Time.deltaTime;
        if (spawnCooldown < 0.0f) {
            Instantiate(bikePrefab, gameObject.transform.position, Quaternion.identity);
            SetCooldown();
        }
    }

    void SetCooldown() {
        this.spawnCooldown = Random.Range(spawnTimeMin, spawnTimeMax);
    }
}
