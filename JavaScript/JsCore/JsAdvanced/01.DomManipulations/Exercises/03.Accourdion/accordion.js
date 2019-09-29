function toggle() {
  let button = document.getElementsByClassName('button')[0];
  console.log(button);
  let text = document.getElementById('extra');
  console.log(text);
  if (button.textContent === 'More') {
    text.style.display = 'block';
    button.textContent = 'Less';
  } else {
    text.style.display = 'none';
    button.textContent = 'More';
  }
}
