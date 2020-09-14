using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Test : MonoBehaviour
{
    public static bool dd;
    // Start is called before the first frame update
    void Start()
    {
        dd = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnParticleTrigger()
    {
        if (CompareTag("Player"))
        {
            BodyTrasform.hp -= Time.deltaTime;
            Debug.Log(BodyTrasform.hp);
        }
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Player"))
        {
            BodyTrasform.hp -= Time.deltaTime;
            Debug.Log(BodyTrasform.hp);
        }
    }
}
