import React from 'react';

const Contact = хаха => {
  const { contactData, onSelectContact } = хаха;
  const { firstName, lastName } = contactData;
  const contactName = `${firstName} ${lastName}`;

  return (
    <div className="contact" data-id="id" onClick={onSelectContact}>
      <span className="avatar small">&#9787;</span>
      <span className="title">{contactName}</span>
    </div>
  );
};

export default Contact;
