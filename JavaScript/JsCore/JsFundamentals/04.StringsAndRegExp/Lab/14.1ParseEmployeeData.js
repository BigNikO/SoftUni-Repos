function employeeData(data) {
  let regex = /^([A-Z][A-Za-z]*) - ([1-9]+[0-9]*) - ([A-Za-z\d \-]+)$/;
  for (let i = 0; i < data.length; i += 1) {
    let match = regex.exec(data[i]);
    if (match) {
      console.log(`Name: ${match[1]}`);
      console.log(`Position: ${match[3]}`);
      console.log(`Salary: ${match[2]}`);
    }
  }
}

employeeData([
  'Jonathan - 2000 - Manager',
  'Peter- 1000- Chuck',
  'George - 1000 - Team Leader',
]);
employeeData([
  'Isacc - 1000 - CEO',
  'Ivan - 500 - Employee',
  'Peter - 500 - Employee',
]);
