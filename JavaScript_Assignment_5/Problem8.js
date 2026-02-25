class Payment {
  pay(amount) {
    console.log(`Payment of ₹${amount} made.`);
  }
}

class CreditCardPayment extends Payment {
  pay(amount) {
    console.log(`Paid ₹${amount} using Credit Card.`);
  }
}

class UPIPayment extends Payment {
  pay(amount) {
    console.log(`Paid ₹${amount} using UPI.`);
  }
}

class CashPayment extends Payment {
  pay(amount) {
    console.log(`Paid ₹${amount} in Cash.`);
  }
}

let payments = [
  new CreditCardPayment(),
  new UPIPayment(),
  new CashPayment()
];

payments.forEach(p => p.pay(1500));