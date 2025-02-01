using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UWE;

public abstract class ItemConverterLocker : MonoBehaviour
{
    public abstract Dictionary<TechType, TechType> ConversionTable { get; }
    public abstract int InputMultiplier { get; } // e.g., 10 for Stacked locker
    public abstract int OutputMultiplier { get; } // e.g., 10 for Unstacked locker

    public StorageContainer lockerStorage;
    public Transform spawnPoint;

    void Start()
    {
        lockerStorage = GetComponent<StorageContainer>();
        if (lockerStorage == null)
        {
            Debug.LogError($"No StorageContainer component found on {gameObject.name}.");
        }
    }

    void Update()
    {
        if (lockerStorage != null && CheckRequiredItems(out TechType inputType, out TechType outputType))
        {
            ConvertItem(inputType, outputType);
        }
    }

    private bool CheckRequiredItems(out TechType inputType, out TechType outputType)
    {
        foreach (var conversion in ConversionTable)
        {
            int requiredAmount = InputMultiplier;
            if (lockerStorage.container.GetCount(conversion.Key) >= requiredAmount)
            {
                inputType = conversion.Key;
                outputType = conversion.Value;
                return true;
            }
        }

        inputType = TechType.None;
        outputType = TechType.None;
        return false;
    }

    private void ConvertItem(TechType inputType, TechType outputType)
    {
        Debug.Log($"Attempting to convert {inputType} to {outputType}...");

        int requiredAmount = InputMultiplier;

        // Check if we can remove the items from the locker
        for (int i = 0; i < requiredAmount; i++)
        {
            if (!lockerStorage.container.DestroyItem(inputType))
            {
                Debug.LogError($"Failed to remove {inputType} from locker.");
                return;
            }
        }

        // Instead of spawning items, we add them directly to the inventory
        for (int i = 0; i < OutputMultiplier; i++)
        {
            // Add the resulting item to the inventory
            CraftData.AddToInventory(outputType, 1); // Add 1 of the output item
            Debug.Log($"Converted {inputType} into {outputType} and added to inventory.");
        }
    }
}
