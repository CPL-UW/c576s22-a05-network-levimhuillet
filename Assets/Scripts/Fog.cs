using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    [SerializeField] private float persistTime;
    private float persistTimer;

    // Start is called before the first frame update
    void Awake()
    {
        persistTimer = persistTime;
    }

    // Update is called once per frame
    void Update()
    {
        persistTime -= Time.deltaTime;

        if (persistTime <= 0) {
            // remove the fog
            Destroy(this.gameObject);
        }
    }
}
