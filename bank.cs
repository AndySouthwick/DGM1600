public class BankAccount {
    private float = moneyTotal;

    public float Balance(){
        return moneytotal;
    }

    public void Deposit(float amount) {
        moneyTotal+= amount;
    }

    public float Withdrawal(float amount){
        if (moneyTotal > amount){
        moneyTotal -= amount;
        return amount;
         } else {
             print('not enough money');
             return null;
             
         }

    }

Deposit(12.45);

}