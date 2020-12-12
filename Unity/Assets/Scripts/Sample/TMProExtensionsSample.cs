using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ykishida.Unity.Utils;

public class TMProExtensionsSample : MonoBehaviour
{


    [SerializeField]
    TextMeshProUGUI TextMeshPro;
    int[] output = new int[3];

    void Start() { ShowText(999); }

    void ShowText(int num)
    {
        TextMeshPro.SetTextNonAlloc(num, output);
    }
}
