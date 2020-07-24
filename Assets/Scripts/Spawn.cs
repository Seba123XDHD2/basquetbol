using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Reloj = null;
    public float timer = 0;
    public int tiempotoSpawn = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= tiempotoSpawn)
        {
            Instantiate(Reloj, gameObject.transform);
            timer = 0;
        }
    }
}
