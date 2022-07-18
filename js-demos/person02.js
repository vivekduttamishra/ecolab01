
function createPerson(name, age){
    var p=new Object(); //
    
    p.name=name; // now object has a name
    p.age=age;

    p.eat=function(food){
 
        console.log(`${this.name} eats ${food}`);
        
    }

    p.move=function(from,to){
        console.log(`${this.name} goes from ${from} to ${to}`);
    }
    
    return p;
}

var vivek=createPerson('Vivek',100);

var shivanshi=createPerson('Shivanshi',14);

vivek.eat('Lunch');
shivanshi.eat('Maggi');