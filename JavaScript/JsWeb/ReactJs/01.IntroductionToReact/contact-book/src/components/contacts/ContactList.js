import React from 'react';

import Contact from './Contact';
import ContactDetails from './ContactDetails';

class ContactList extends React.Component {
  state = {
    contact: null,
  };

  getContact = contact => {
    this.setState({ contact });
  };

  render() {
    const { contacts } = this.props;
    const { contact } = this.state;

    return (
      <React.Fragment>
        <div id="list">
          <h1>Contacts</h1>
          <div className="content">
            {contacts.map((contact, index) => (
              <Contact
                contactData={contact}
                key={index}
                onSelectContact={() => this.getContact(contact)}
              />
            ))}
          </div>
        </div>
        <ContactDetails contact={contact} />
      </React.Fragment>
    );
  }
}

export default ContactList;
