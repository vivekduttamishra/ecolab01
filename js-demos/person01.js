

var p=new Object(); //
// we have an object but we don't know any property or behavior

//we can add the properties or behavior after creating the object


p.name='Vivek'; // now object has a name
p.age=100;

console.log(p);

console.log(p.name);
console.log(p.age);

//person can have behavior 

p.eat=function(food){
 
    console.log(`${this.name} eats ${food}`);
    
}


p.eat('Lunch');