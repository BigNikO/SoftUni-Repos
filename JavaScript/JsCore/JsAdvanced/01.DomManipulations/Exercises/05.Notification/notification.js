function notify(message) {
  let toast = document.getElementById('notification');
  console.log(toast);
  toast.textContent = message;
  toast.style.display = 'block';

  setTimeout(() => {
    toast.style.display = 'none';
  }, 2000);
}
