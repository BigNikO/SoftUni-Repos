import React, { Component } from 'react';
import AppRouter from '../AppRouter';
import Header from './Header';

class Layout extends Component {
  state = {
    user: {
      isLoggedIn: false,
      username: '',
      isAdmin: false,
    },
  };

  componentDidMount() {
    const username = localStorage.getItem('username');
    const token = localStorage.getItem('token');
    const isAdmin = localStorage.getItem('isAdmin');
    if (token) {
      this.setState({
        user: {
          isLoggedIn: true,
          username: username,
          isAdmin: isAdmin,
        },
      });
    }
  }

  componentDidUpdate() {
    if (this.state.user.username !== localStorage.getItem('username')) {
      const username = localStorage.getItem('username');
      const token = localStorage.getItem('token');
      const isAdmin = localStorage.getItem('isAdmin');

      this.setState({
        user: {
          isLoggedIn: !!token,
          username: username,
          isAdmin: isAdmin,
        },
      });
    }
  }

  render() {
    const { user } = this.state;

    return (
      <React.Fragment>
        <Header user={user} />
        <AppRouter />
      </React.Fragment>
    );
  }
}

export default Layout;
