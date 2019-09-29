function convertToUpper(str) {
    console.log(str.split(/\W+/)
        .filter(w=>w!=="")
        .map(w=>w.toUpperCase())
        .join(', '));
}
// convertToUpper("sdasafgsdgfd fgfdgfdgfdg    gfgdfgd");
// convertToUpper("Nikola Ivan Petkan");
// convertToUpper("softuni study");
