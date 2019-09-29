import React from 'react';
import './register.css';

class RegisterForm extends React.Component {
  state = {
    username: null,
    password: null,
    email: null,
  };

  handleChange = event => {
    const { name, value } = event.target;
    this.setState({ [name]: value });
  };

  render() {
    const { registerUser } = this.props;
    return (
      <div className="Register">
        <h1>Sign Up</h1>
        <form
          onSubmit={event => {
            event.preventDefault();
            registerUser(this.state);
          }}
          onChange={this.handleChange}
        >
          <label>Username</label>
          <input type="text" id="usernameReg" name="username" />
          <label>Email</label>
          <input type="text" id="emailReg" name="email" />
          <label>Password</label>
          <input type="password" id="passwordReg" name="password" />
          <input type="submit" value="Sign Up" />
        </form>
      </div>
    );
  }
}
export default RegisterForm;
