using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;
public class İAP : MonoBehaviour
  
{
    public string premiumName = "com.ogretgen.kitap";
  public void OnPurchaseComplete(Product product)
    {
        if (product.definition.id==premiumName)
        {
            Debug.Log("premium oldunuz ");
            SceneSwitcher.playGame();

        }
    }

    public void OnPurchaseFailed(Product product,PurchaseFailureReason reason)
    {
        Debug.Log(" premium olmadınız ");
    } 







}
