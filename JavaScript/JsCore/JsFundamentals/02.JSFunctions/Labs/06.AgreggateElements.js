function aggregateElements(elements) {
    aggregate(elements, 0, (a, b) => a + b);
    // аggregate(elements, 0, function (a, b) {return a+b;};
    aggregate(elements, 0, (a, b) => a + 1 / b);
    aggregate(elements, '', (a, b) => a + b);
    function aggregate(arr, initialValue, func){
        for (let i = 0; i < arr.length; i++) {
            initialValue = func(initialValue, arr[i]);
        }
        console.log(initialValue);
    }
}

// aggregateElements([10,20,30]);
// aggregateElements([10,20,30,40]);
// aggregateElements([10,20,30,50,70]);