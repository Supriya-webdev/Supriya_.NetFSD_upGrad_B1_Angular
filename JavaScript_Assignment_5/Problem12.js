class Wallet {
  #balance;

  constructor(initialBalance = 0) {
    this.#balance = initialBalance; 
  }

  addMoney(amount) {
    if (amount > 0) {
      this.#balance += amount;
      console.log(`₹${amount} added. Current Balance: ₹${this.#balance}`);
    } else {
      console.log("Enter a valid amount to add.");
    }
  }

  spendMoney(amount) {
    if (amount > this.#balance) {
      console.log(`Insufficient funds! Current Balance: ₹${this.#balance}`);
    } else if (amount <= 0) {
      console.log("Enter a valid amount to spend.");
    } else {
      this.#balance -= amount;
      console.log(`₹${amount} spent. Current Balance: ₹${this.#balance}`);
    }
  }

  getBalance() {
    console.log(`Current Balance: ₹${this.#balance}`);
    return this.#balance;
  }
}

let myWallet = new Wallet(500);
myWallet.getBalance();      
myWallet.addMoney(200);     
myWallet.spendMoney(1000);  
myWallet.spendMoney(300);   

