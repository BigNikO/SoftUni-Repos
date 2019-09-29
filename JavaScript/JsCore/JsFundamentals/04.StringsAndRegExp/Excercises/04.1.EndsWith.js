function endsWith(inputString, endString) {
  console.log(
    inputString.substring(inputString.indexOf(endString)) === endString
  );
}

endsWith('This sentence ends with fun?', 'fun?');
