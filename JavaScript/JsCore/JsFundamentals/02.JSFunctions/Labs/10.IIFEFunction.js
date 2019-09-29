(function saySomething(something) {
    console.log(something)

})("Hello");

(function (parameter) {
    let a = 5;
    let b = 6;
    let c = 7;
    let sum = (a+b+c+parameter)
    console.log(sum)
})(13)