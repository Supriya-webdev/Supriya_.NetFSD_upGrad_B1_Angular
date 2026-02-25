class Shape {
  calculateArea() {
    console.log("Area calculation not implemented for generic shape.");
  }
}

class Circle extends Shape {
  constructor(radius) {
    super();
    this.radius = radius;
  }

  calculateArea() {
    let area = Math.PI * this.radius ** 2;
    console.log(`Circle with radius ${this.radius} → Area: ${area.toFixed(2)}`);
    return area;
  }
}

class Rectangle extends Shape {
  constructor(width, height) {
    super();
    this.width = width;
    this.height = height;
  }

  calculateArea() {
    let area = this.width * this.height;
    console.log(`Rectangle ${this.width} x ${this.height} → Area: ${area}`);
    return area;
  }
}

class Triangle extends Shape {
  constructor(base, height) {
    super();
    this.base = base;
    this.height = height;
  }

  calculateArea() {
    let area = 0.5 * this.base * this.height;
    console.log(`Triangle base ${this.base}, height ${this.height} → Area: ${area}`);
    return area;
  }
}

let shapes = [
  new Circle(5),
  new Rectangle(4, 6),
  new Triangle(3, 8)
];

shapes.forEach(shape => shape.calculateArea());