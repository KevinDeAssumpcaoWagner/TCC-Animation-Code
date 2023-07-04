using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public void Activate()
    {
        // Ativa a arma
        gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        // Desativa a arma
        gameObject.SetActive(false);
    }
}
