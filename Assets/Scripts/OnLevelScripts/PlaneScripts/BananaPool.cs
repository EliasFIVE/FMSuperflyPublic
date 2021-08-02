using System.Collections.Generic;
using UnityEngine;

public class BananaPool : MonoBehaviour
{
    [Header("Set In Inspector")]
    [SerializeField] private List<GameObject> bananas;

    public GameObject GetBananaByIndex(int index)
    {
        return bananas[index];
    }
}
