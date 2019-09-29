import React, { Component } from 'react';
import './Register.css';
import { registerUser } from '../Utils/actions';

class Register extends Component {
  state = {
    username: null,
    password: null,
    email: null,
  };

  handleChange = event => {
    const { name, value } = event.target;
    this.setState({ [name]: value });
  };

  onSubmit = async event => {
    event.preventDefault();
    try {
      await registerUser(this.state);
      this.props.history.push('/');
    } catch (err) {
      console.log(err);
    }
  };

  render() {
    return (
      <div className="Register">
        <h1>Register</h1>
        <form onSubmit={this.onSubmit} onChange={this.handleChange}>
          <label htmlFor="username">Username</label>
          <input
            type="text"
            id="username"
            name="username"
            placeholder="Ivan Ivanov"
          />
          <label htmlFor="email">Email</label>
          <input
            type="text"
            id="email"
            name="email"
            placeholder="ivan@gmail.com"
          />
          <label htmlFor="password">Password</label>
          <input
            type="password"
            id="password"
            name="password"
            placeholder="******"
          />
          <input type="submit" value="REGISTER" />
        </form>
      </div>
    );
  }
}

export default Register;
