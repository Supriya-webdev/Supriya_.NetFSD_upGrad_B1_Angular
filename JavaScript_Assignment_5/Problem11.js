class User {
  constructor(password) {
    this._password = password;
  }

  get password() {
    return this._password;
  }

  set password(newPassword) {
    if (typeof newPassword === "string" && newPassword.length >= 6) {
      this._password = newPassword;
      console.log("Password updated successfully!");
    } else {
      console.log("Error: Password must be at least 6 characters long.");
    }
  }
}


let user1 = new User("secret123");

console.log(user1.password); 

user1.password = "abc";      
user1.password = "mypassword"; 
console.log(user1.password); 