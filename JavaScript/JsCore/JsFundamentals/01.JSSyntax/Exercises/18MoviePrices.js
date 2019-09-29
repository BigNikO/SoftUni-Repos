function moviePrice([title, day]) {
  let result = "error";
  title = title.toLowerCase();
  if (title === 'the godfather') {
    switch (day.toUpperCase()) {
      case 'MONDAY':
        return 12;
      case "TUESDAY":
        return 10;
      case 'WEDNESDAY':
      case 'FRIDAY':
        return 15;
      case 'THURSDAY':
        return 12.5;
      case "SATURDAY":
        return 25;
      case "SUNDAY":
        return 30;
    }
  } else if (title === "schindler's list") {
    switch (day.toUpperCase()) {
      case 'SATURDAY':
      case 'SUNDAY':
        return 15;
      case "MONDAY":
      case "TUESDAY":
      case "WEDNESDAY":
      case "THURSDAY":
      case "FRIDAY":
        return 8.5;
    }
  } else if (title === "casablanca") {
    switch (day.toUpperCase()) {
      case 'SATURDAY':
      case 'SUNDAY':
        return 10;
      case "MONDAY":
      case "TUESDAY":
      case "WEDNESDAY":
      case "THURSDAY":
      case "FRIDAY":
        return 8;
    }
  }
  else if (title === "the wizard of oz") {
    switch (day.toUpperCase()) {
      case 'SATURDAY':
      case 'Sunday':
        return 15;
      case "MONDAY":
      case "TUESDAY":
      case "WEDNESDAY":
      case "THURSDAY":
      case "FRIDAY":
        return 10;
    }
  }
  return result;
}

// console.log(moviePrice(['The Wizard of Oz','MoNdaY']));