function sumNumbers() {
    let number1 = Number(document.getElementById('num1').value);
    let number2 = Number(document.getElementById('num2').value);
    document.getElementById('result').textContent = number1 + number2;
}