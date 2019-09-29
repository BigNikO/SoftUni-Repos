import React, { Component } from 'react';
import './Warning.css';
import Article from './Components/article/Article';
import Register from './Components/register/Register';
import BindingForm from './Components/bindingForm/BindingForm';
import Navigation from './Components/navigation/Navigation';
import WithWarning from './Components/hocs/WithWarning';
import WithError from './Components/hocs/WithError';

const ArticleWithWarning = WithError(WithWarning(Article));
const RegisterWithWarning = WithError(WithWarning(Register));
const NavigationWithWarining = WithError(WithWarning(Navigation));

class App extends Component {
  onSubmit(e, data) {
    e.preventDefault();
    console.log(data);
  }
  render() {
    return (
      <section>
        <BindingForm onSubmit={this.onSubmit}>
          <input type="text" name="username" />
          <input type="password" name="password" />
        </BindingForm>
        <ArticleWithWarning />
        <RegisterWithWarning />
        <NavigationWithWarining />
      </section>
    );
  }
}

export default App;
