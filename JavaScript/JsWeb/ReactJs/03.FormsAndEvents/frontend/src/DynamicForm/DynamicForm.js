import React from 'react';
import RegisterForm from './RegisterForm';
import LogInForm from './LoginForm';
import CreateForm from '../Games/CreateForm';

class DynamicForm extends React.Component {
  render() {
    const { registerUser, loginUser, loginForm, user, createGame } = this.props;
    return (
      <div>
        <div>
          {!loginForm
            ? !user && <RegisterForm registerUser={registerUser} />
            : !user && (
                <LogInForm loginUser={loginUser} loginForm={loginForm} />
              )}
          {user && <CreateForm createGame={createGame} user={user} />}
        </div>
      </div>
    );
  }
}

export default DynamicForm;
