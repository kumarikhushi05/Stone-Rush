using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{
    [SerializeField] AudioSource gemFX;

    void OnTriggerEnter(Collider other)
    {
        gemFX.Play();
        MasterInfo.gemCount += 1;
        this.gameObject.SetActive(false);
    }

}
