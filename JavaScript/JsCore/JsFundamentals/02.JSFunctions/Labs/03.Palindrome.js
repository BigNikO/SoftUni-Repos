function palindrome(word = "racecar") {
    let check = true;
    for (let i = 0; i < word.length / 2; i++) {
        if (word[i] !== word[word.length - 1 - i]) {
            check = false;
        }
    }
    console.log(check)
}

// palindrome();
// palindrome('grandma');
// palindrome('ABBA');
// palindrome('LoL');




