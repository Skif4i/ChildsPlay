using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnCollision : MonoBehaviour
{
    public GameObject objectToHide; // ������, ������� ����� ������

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == objectToHide)
        {
            objectToHide.SetActive(false);
        }
    }
}
