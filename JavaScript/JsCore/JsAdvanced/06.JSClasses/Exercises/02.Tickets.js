function getTickets(tickets, criteria) {
  class Ticket {
    constructor(destination, price, status) {
      this.destination = destination;
      this.price = price;
      this.status = status;
    }
  }

  const result = tickets
    .map(e => {
      const elements = e.split('|');
      const destination = elements[0];
      const price = +elements[1];
      const status = elements[2];

      const ticket = new Ticket(destination, price, status);
      return ticket;
    })
    .sort((a, b) => {
      return a[criteria] - b[criteria] || a[criteria] > b[criteria];
    });

  return result;
}

console.log(
  getTickets(
    [
      'Philadelphia|94.20|available',
      'New York City|95.99|available',
      'Boston|126.20|departed',
      'New York City|95.99|sold',
    ],
    'destination'
  ),
  getTickets(
    [
      'Philadelphia|94.20|available',
      'New York City|95.99|available',
      'New York City|95.99|sold',
      'Boston|126.20|departed',
    ],
    'status'
  )
);
