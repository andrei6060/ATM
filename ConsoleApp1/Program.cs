using System;

public class cardHolder
{
    String cardNum;
    int cardPin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int cardPin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.cardPin = cardPin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public String getCardNum() { return cardNum; }
    public void setCardNum(String cardNum) {  this.cardNum = cardNum; }


    public int getCardPin() { return cardPin; }
    public void setCardPin(int cardPin) { this.cardPin = cardPin; }    


    public String getFirstName() { return firstName; } 
    public void setFirstName(String firstName) { this.firstName = firstName;}


    public String getLastName() { return lastName;}
    public void setLastName(String lastName) { this.lastName = lastName; }
    

    public double getBalance() { return balance; }
    public void setBalance(double balance) {  this.balance = balance; }

    public static void main(String[] args)
    {
        void printOpptions()
        {
            Console.WriteLine("Choose one of the options below:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
         }

        void deposit(cardHolder cardHolder)
        {

        }
    }

}
