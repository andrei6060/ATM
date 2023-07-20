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
    public void setCardNum(String cardNum) { this.cardNum = cardNum; }


    public int getCardPin() { return cardPin; }
    public void setCardPin(int cardPin) { this.cardPin = cardPin; }


    public String getFirstName() { return firstName; }
    public void setFirstName(String firstName) { this.firstName = firstName; }


    public String getLastName() { return lastName; }
    public void setLastName(String lastName) { this.lastName = lastName; }


    public double getBalance() { return balance; }
    public void setBalance(double balance) { this.balance = balance; }

    public static void Main(String[] args)
    {
        void printOpptions()
        {
            Console.WriteLine("Choose one of the numbers from 1 to 4:");
            Console.WriteLine("1-Deposit");
            Console.WriteLine("2-Withdraw");
            Console.WriteLine("3-Show Balance");
            Console.WriteLine("4-Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much will you deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdraw = Double.Parse(Console.ReadLine());
            if (withdraw <= currentUser.getBalance())
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
            }
            else
            {
                Console.WriteLine("Cannot withdraw more than your current balance. Your balance is $" + currentUser.getBalance());
            }
        }

        void showBalance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is" + currentUser.getBalance());
        }
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("8765123445678765", 1234, "Gogu", "George", 234.54));
        cardHolders.Add(new cardHolder("9765422455678765", 2134, "Gigi", "Gheorghe", 243.54));
        cardHolders.Add(new cardHolder("7765123445678765", 2143, "Gogi", "George", 243.54));
        cardHolders.Add(new cardHolder("6765123445678765", 0000, "Gicu", "Gheorghe", 223.54));
        cardHolders.Add(new cardHolder("5765123445678765", 4321, "Gicu", "George", 123.54));
        string cardNum = "";
        cardHolder current;

        while(true)
        {
            try
            {
                cardNum = Console.ReadLine();
                current = cardHolders.FirstOrDefault(a => a.getCardNum().Equals(cardNum));
                if(current != null)
                {
                    break;
                }else { 
                    Console.WriteLine("insert a valid card number");
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
        }
        int pin;

        while (true)
        {
            try
            {
                pin = int.Parse( Console.ReadLine());
                if (current.getCardPin() == pin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("not the correct pin");
                }
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        Console.WriteLine("Welcome " + current.getFirstName() + " " + current.getLastName());

        int currentCmd = -1;
        while (currentCmd != 4) {
            currentCmd = int.Parse( Console.ReadLine());
           // Console.WriteLine(currentCmd);
            if (currentCmd == 1) {
                deposit(current);
            } else if (currentCmd == 2) {
                withdraw(current);
            } else if (currentCmd == 3) { 
                showBalance(current);
            } else if (currentCmd != 4)
            {
                printOpptions();
            }

        }

    }


}

