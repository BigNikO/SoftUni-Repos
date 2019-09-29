let closure = (function () {
    let a = 1;
    return function () {console.log(a++)}
}());

closure();
closure();
closure();
closure();
closure();
closure();
closure();
closure();
closure();
closure();