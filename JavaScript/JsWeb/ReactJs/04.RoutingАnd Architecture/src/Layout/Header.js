import React from 'react';
import { Link } from 'react-router-dom';
import { logoutUser } from '../Utils/actions';

class Header extends React.Component {
  logout = () => {
    logoutUser();
  };
  render() {
    const { user } = this.props;
    const { isLoggedIn, isAdmin, username } = user;

    const Navigation = (
      <span>
        {isLoggedIn && (
          <span>
            <Link to="#">{username}</Link>
            {isAdmin && (
              <span>
                <Link to="/create">Create</Link>
              </span>
            )}
            <Link to="/" onClick={this.logout}>
              Logout
            </Link>
          </span>
        )}
        {!isLoggedIn && (
          <span>
            <Link to={'/register'}>Register</Link>
            <Link to={'/login'}>Login</Link>
          </span>
        )}
      </span>
    );

    return (
      <header>
        <Link to="/" className="logo">
          Interactive IMDB
        </Link>
        <div className="header-right">
          <Link to="/">Home</Link>
          {Navigation}
        </div>
      </header>
    );
  }
}

export default Header;
