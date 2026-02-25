class Product {
  constructor({ name, price, category = "General" }) {
    this.name = name;
    this.price = price;
    this.category = category;
  }

  displayInfo = () => {
    console.log(`Product: ${this.name} | Price: ₹${this.price} | Category: ${this.category}`);
  }

  applyDiscount = (discountPercent) => {
    let discountedProduct = { ...this, price: this.price * (1 - discountPercent / 100) };
    console.log(`After ${discountPercent}% discount → Price: ₹${discountedProduct.price.toFixed(2)}`);
    return discountedProduct;
  }

  updateDetails = ({ name, price, category }) => {
    if (name) this.name = name;
    if (price) this.price = price;
    if (category) this.category = category;
  }
}

let prod1 = new Product({ name: "Laptop", price: 60000, category: "Electronics" });
prod1.displayInfo(); 

let prodAfterDiscount = prod1.applyDiscount(10); 

prod1.updateDetails({ price: 55000, category: "Computers" });
prod1.displayInfo(); 

let prod2 = new Product({ name: "Notebook", price: 50 });
prod2.displayInfo(); 