﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feijao : MonoBehaviour
{
    [SerializeField] private GameObject _imagem;
    [SerializeField] private static int contador = 25;
    
    public void spawn_faijao()
    {
        if (contador > 0)
        {
            Instantiate(_imagem, new Vector3(0, 0, 0), Quaternion.identity);
            contador--;
        }
    }
}