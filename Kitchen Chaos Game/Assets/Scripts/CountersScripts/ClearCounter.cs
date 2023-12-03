using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            // Counter has no KitchenObject here
            if (player.HasKitchenObject()) {
                // Player is carrying something
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else {
                // Player not carrying anything
            }
        }
        else {
            // Counter has a KitchenObject here
            if (player.HasKitchenObject()) {
                // Player is carrying something
            }
            else {
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
