import React from 'react';
import ContactBook from '../contacts/ContactBook';
import Header from './Header';
import Footer from './Footer';
import contacts from '../../database/contacts.json';

const Layout = () => {
  return (
    <div className="container">
      <Header />
      <ContactBook contacts={contacts} />
      <Footer />
    </div>
  );
};

export default Layout;
