﻿namespace Scripts.Inventory
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Stone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            print("sss");
            if (other.CompareTag("Player"))
            {
                InventoryManager.Instance.AddItem("stone");
                gameObject.SetActive(false);
            }
        }
    }
}
