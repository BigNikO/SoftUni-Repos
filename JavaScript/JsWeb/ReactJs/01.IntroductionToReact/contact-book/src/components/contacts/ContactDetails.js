import React from 'react';

const defaultContact = {
  firstName: 'Ivan',
  lastName: 'Ivanov',
  phone: '0888 123 456',
  email: 'i.ivanov@gmail.com',
};

const ContactDetails = props => {
  const { contact } = props;
  const { firstName, lastName, phone, email } = contact || defaultContact;

  return (
    <div id="details">
      <h1>Details</h1>
      <div className="content">
        <div className="info">
          <div className="col">
            <span className="avatar">&#9787;</span>
          </div>
          <div className="col">
            <span className="name">{firstName}</span>
            <span className="name">{lastName}</span>
          </div>
        </div>
        <div className="info">
          <span className="info-line">&#9742; {phone}</span>
          <span className="info-line">&#9993; {email}</span>
        </div>
      </div>
    </div>
  );
};

export default ContactDetails;
