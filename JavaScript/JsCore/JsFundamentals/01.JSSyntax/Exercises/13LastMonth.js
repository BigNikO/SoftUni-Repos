// function lastDayOfPreviousMonth(date) {
//   let day = 30;
//   let month = date[1];
//   let year = date[2];
//   switch (month) {
//     case 3:
//       {
//         if ((year % 4 === 0 && !(year % 100 === 0)) || year % 400 === 0) {
//           day = 29;
//         } else {
//           day = 28;
//         }
//       }
//       break;
//     case 5:
//     case 7:
//     case 10:
//       day = 30;
//       break;
//     default:
//       day = 31;
//       break;
//   }
//   console.log(day);
// }

function lastDayOfPreviousMonth(givenDate) {
  let month = givenDate[1];
  let year = givenDate[2];
  let date = new Date(year, month - 1, 0);
  let numberOfDays = date.getDate();
  console.log(numberOfDays);
}

lastDayOfPreviousMonth([13, 3, 1004]);
