class Employee {
  constructor(name, salary) {
    this.name = name;
    this.salary = salary;
  }

  getDetails() {
    console.log(`Employee Name: ${this.name}, Base Salary: ₹${this.salary}`);
  }
}

class Manager extends Employee {
  constructor(name, salary, bonus) {
    super(name, salary); 
    this.bonus = bonus;
  }

  getTotalSalary() {
    return this.salary + this.bonus;
  }
}

class Director extends Manager {
  constructor(name, salary, bonus, stockOptions) {
    super(name, salary, bonus); 
    this.stockOptions = stockOptions;
  }

  getFullCompensation() {
    return this.getTotalSalary() + this.stockOptions;
  }
}

let emp = new Employee("Rahul", 50000);
emp.getDetails(); 

let mgr = new Manager("Anita", 70000, 15000);
mgr.getDetails(); 
console.log(`Total Salary with Bonus: ₹${mgr.getTotalSalary()}`); 

let dir = new Director("Karan", 90000, 20000, 50000);
dir.getDetails(); 
console.log(`Total Salary + Bonus: ₹${dir.getTotalSalary()}`);
console.log(`Full Compensation (including Stock): ₹${dir.getFullCompensation()}`); 