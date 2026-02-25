class BankAccount {
  constructor(accountHolder, balance = 0) {
    this.accountHolder = accountHolder;
    this.balance = balance;
  }

  deposit(amount) {
    if (amount > 0) {
      this.balance += amount;
      console.log(`₹${amount} deposited. New Balance: ₹${this.balance}`);
    } else {
      console.log("Enter a valid amount to deposit.");
    }
  }

  withdraw(amount) {
    if (amount > this.balance) {
      console.log(`Insufficient funds! Current Balance: ₹${this.balance}`);
    } else if (amount <= 0) {
      console.log("Enter a valid amount to withdraw.");
    } else {
      this.balance -= amount;
      console.log(`₹${amount} withdrawn. New Balance: ₹${this.balance}`);
    }
  }

  checkBalance() {
    console.log(`Account Holder: ${this.accountHolder}, Balance: ₹${this.balance}`);
  }
}

let acc1 = new BankAccount("Rahul", 5000);

acc1.checkBalance();  
acc1.deposit(2000);    
acc1.withdraw(8000);   
acc1.withdraw(3000);   
acc1.checkBalance();   