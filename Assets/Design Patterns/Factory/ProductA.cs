using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductA : MonoBehaviour, IProduct
{
    [SerializeField] private string productName = "ProductA";
    public string ProductName { get => productName; set => productName = value; }
    private ParticleSystem particle;

    public void Initialize()
    {
        // any unique logic to this product
        gameObject.name = productName;
        particle = GetComponentInChildren<ParticleSystem>();
        particle?.Stop();
        particle?.Play();
    }
}
