import React from 'react';
import './login.css';

class LogInForm extends React.Component {
  state = {
    username: null,
    password: null,
  };

  handleChange = event => {
    const { name, value } = event.target;
    this.setState({ [name]: value });
  };

  render() {
    const { loginUser } = this.props;
    return (
      <div className="Login">
        <h1>Login</h1>
        <form
          onSubmit={event => {
            event.preventDefault();
            loginUser(this.state);
          }}
          onChange={this.handleChange}
        >
          <label>Usersname</label>
          <input type="text" id="usernameLogin" name="username" />
          <label>Password</label>
          <input type="password" id="passwordLogin" name="password" />
          <input type="submit" value="Login" />
        </form>
      </div>
    );
  }
}

export default LogInForm;
