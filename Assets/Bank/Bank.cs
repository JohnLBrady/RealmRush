using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bank : MonoBehaviour
{
    [SerializeField] int starterBalance = 150;
    [SerializeField] int currentBalance;
    public int CurrentBalance{get{return currentBalance;}}

    MoneyTmp moneyTmp;

    void Awake(){
        currentBalance = starterBalance;  
    }

    void Start(){
        moneyTmp = FindObjectOfType<MoneyTmp>();
        moneyTmp.UpdateBalance(currentBalance);
    }

    public void Deposit(int amount){
        currentBalance += Mathf.Abs(amount);
        moneyTmp.UpdateBalance(currentBalance);
    }

    public void Withdraw(int amount){
        currentBalance -= Mathf.Abs(amount);
        moneyTmp.UpdateBalance(currentBalance);

        if(currentBalance < 0){
            //Lose the game
            ReloadScene();
        }
    }

    void ReloadScene(){
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
