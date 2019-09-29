import React, { Component } from 'react';
import './Login.css';
import { loginUser } from '../Utils/actions';

class Login extends Component {
  state = {
    username: null,
    password: null,
  };

  onHandleChange = event => {
    const { name, value } = event.target;
    this.setState({ [name]: value });
  };

  onSubmit = async event => {
    event.preventDefault();
    await loginUser(this.state);
    this.props.history.push('/');
  };
  render() {
    return (
      <div className="Login">
        <h1>Login</h1>
        <form onSubmit={this.onSubmit} onChange={this.onHandleChange}>
          <label htmlFor="usernameLogin">Username</label>
          <input
            type="text"
            id="usernameLogin"
            name="username"
            placeholder="Ivan Ivanov"
          />
          <label htmlFor="passwordLogin">Password</label>
          <input
            type="password"
            id="passwordLogin"
            name="password"
            placeholder="******"
          />
          <input type="submit" value="Login" />
        </form>
      </div>
    );
  }
}

export default Login;
