class Person {
  constructor(name, age) {
    this.name = name;
    this.age = age;
  }

  greet() {
    console.log(`Hello, my name is ${this.name} and I am ${this.age} years old.`);
  }
}

let p1 = new Person("Rahul", 25);
let p2 = new Person("Meena", 30);

p1.greet(); 
p2.greet(); 