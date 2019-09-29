import React from 'react';

import ContactList from './ContactList';

const ContactBook = props => {
  const { contacts } = props;

  return (
    <div id="book">
      <ContactList contacts={contacts} />
    </div>
  );
};

export default ContactBook;
