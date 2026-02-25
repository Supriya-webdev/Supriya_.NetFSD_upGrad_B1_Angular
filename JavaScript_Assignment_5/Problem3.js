class Student {
  constructor(name) {
    this.name = name;
    this.marks = []; // stores marks
  }

  addMark(mark) {
    if (mark >= 0 && mark <= 100) {
      this.marks.push(mark);
      console.log(`Added mark ${mark} for ${this.name}`);
    } else {
      console.log("Enter a valid mark between 0 and 100");
    }
  }

  getAverage() {
    if (this.marks.length === 0) return 0;
    let sum = this.marks.reduce((acc, m) => acc + m, 0);
    return sum / this.marks.length;
  }

  getGrade() {
    const avg = this.getAverage();
    if (avg >= 90) return "A";
    else if (avg >= 75) return "B";
    else if (avg >= 50) return "C";
    else return "Fail";
  }
}

let student1 = new Student("Rahul");
student1.addMark(80);
student1.addMark(90);
student1.addMark(70);

console.log(`Average Marks: ${student1.getAverage()}`); 
console.log(`Grade: ${student1.getGrade()}`);         