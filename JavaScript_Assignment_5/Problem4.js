class Vehicle {
  constructor(brand, speed) {
    this.brand = brand;
    this.speed = speed;
  }

  start() {
    console.log(`${this.brand} is starting at ${this.speed} km/h.`);
  }
}

class Car extends Vehicle {
  constructor(brand, speed, fuelType) {
    super(brand, speed); 
    this.fuelType = fuelType;
  }

  showDetails() {
    super.start();
    console.log(`Fuel Type: ${this.fuelType}`);
  }
}

let myCar = new Car("Toyota", 120, "Petrol");
myCar.showDetails();

let bike = new Vehicle("Yamaha", 80);
bike.start(); 